# PEC API client library

Unofficial .NET library for accessing the PEC API with partial implementation (order pick-up points, calculator).

- [NuGet](https://www.nuget.org/packages/XyloCode.ThirdPartyServices.Pecom) (.NET library)
- [GitHub](https://github.com/xylocode/ThirdPartyServices.Pecom) (source code)
- [Official documentation](https://kabinet.pecom.ru/api/v1)

#### Supported Platforms

- .NET 6.0 LTS;
- .NET 7.0.

## PEC

PEK (russian abbr. ПЭК - Первая Экспедиционная Компания, english - First Forwarding Company) is a multi-service logistics operator, an expert in the field of integrated solutions and organization of cargo transportation in Russia and abroad. The company was founded in 2001. The PEC branch network includes over 300 branches in Russia, Azerbaijan, Armenia, Belarus, Kazakhstan, Uzbekistan, Tajikistan, Kyrgyzstan, Turkey and China. Every year, 4.5 million clients use the company’s services.

Official website: [https://www.pecom.ru/](https://www.pecom.ru/).

## Supported Methods

- Authorization
- Getting User Profile Data
- List of all branches and cities
- Getting the nearest dates and time intervals for cargo pickup/delivery
- Calculation

## How to use

```cs
using XyloCode.ThirdPartyServices.Pecom;
using XyloCode.ThirdPartyServices.Pecom.Calculation.Req;
using XyloCode.ThirdPartyServices.Pecom.Enums;
using XyloCode.ThirdPartyServices.Pecom.Helpers;
using XyloCode.ThirdPartyServices.Pecom.Models;
using XyloCode.ThirdPartyServices.Pecom.Requests;

namespace PecomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string login = "my_login"; // login for https://pecom.ru/
            const string apiKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"; // api-key from https://pecom.ru/

            var tracer = new LoggingHandler(); // for tracing, needed only for debugging
            var api = new PecClient(login, apiKey, httpMessageHandler: tracer);

            // Getting list of all branches and cities
            var branchs = api.GetAllBranches();

            
            // Getting the nearest dates and time intervals for cargo pickup
            var timeslotReq = new DeliveryTimeSlotRequest
            {
                Date = DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
                CalculateDays = 3,
                Address = "Город Москва, ул Вавилова, д. 19",
            };
            var deliverydays = api.GetDeliveryTimeSlots(timeslotReq);
            var plannedDate = GetPlannedDate(deliverydays);
            

            // Calculation
            var calc = new CalculationRequest
            {
                TransportingTypes = new List<ProductType> { ProductType.LTL },
                IsPickUp = true,
                IsDelivery = true,
                PlannedDateTime = plannedDate,
                Cargos = new List<Cargo>
                {
                    new Cargo
                    {
                        Length = 1,
                        Width = 0.3,
                        Height = 1,
                        Weight = 76,
                    },
                },
                InsurancePrice = 35_000,
                Pickup = new Point("Город Москва, ул Вавилова, д. 19"),
                Delivery = new Point("630099, Новосибирская область, г Новосибирск, пр-кт Димитрова, зд. 2"),
                Counterpart = new Counterpart
                {
                    Inn = "7707083893",
                    WhoMakesCalculation = new List<RoleType> { RoleType.Payer, RoleType.Sender },
                }
            };
            var resCalc = api.Calculation(calc);
        }


        // Select nearest date and time for cargo pickup
        private static DateTime GetPlannedDate(List<DeliveryTimeSlot> list)
        {
            foreach (var day in list)
            {
                if (!day.Date.HasValue) continue;
                var date = day.Date.Value;
                foreach (var ts in day.TimeSlots)
                {
                    if (!ts.PeriodTimeFrom.HasValue) continue;
                    var time = ts.PeriodTimeFrom.Value.AddMinutes(5);
                    if (ts.PeriodTimeFrom?.Hour > 9 && ts.PeriodTimeTo?.Hour < 15)
                    {
                        return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0);
                    }
                }
            }
            throw new Exception();
        }
    }
}
```

## License

MIT License
