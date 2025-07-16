namespace PlaceRichEditInEditForm.Data
{
    public partial class SampleData
    {
        public static List<Employee> Employees = new List<Employee> {
            new Employee {
                ID = 1,
                Name = "Nancy Davolio",
                Address = "507 - 20th Ave. E.Apt. 2A",
                Phone = "(206) 555-9857",
                Notes = "Components\\Data\\Notes\\NancyDavolio.docx",
            },
            new Employee {
                ID = 2,
                Name = "Andrew Fuller",
                Address = "908 W. Capital Way",
                Phone = "(206) 555-9482",
                Notes = "Components\\Data\\Notes\\AndrewFuller.docx",
            },
            new Employee {
                ID = 3,
                Name = "Janet Leverling",
                Address = "722 Moss Bay Blvd.",
                Phone = "(206) 555-3412",
                Notes = "Components\\Data\\Notes\\JanetLeverling.docx",
            },
            new Employee {
                ID = 4,
                Name = "Margaret Peacock",
                Address = "4110 Old Redmond Rd.",
                Phone = "(206) 555-8122",
                Notes = "Components\\Data\\Notes\\MargaretPeacock.docx",
            }
        };
    }
}