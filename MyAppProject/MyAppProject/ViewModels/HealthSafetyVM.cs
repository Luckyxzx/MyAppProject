using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyAppProject.ViewModels
{
    public class HealthSafetyVM : VMBase
    {

        public class HSItem
        {
            //set variable to be used
            public string Title { get; set; }
            public string Description { get; set; }
         
        }

        //declare pub name healthandsafetyitems of type observablecollection<hsitem>
        //hsitem class/data structure which represents items thats within health and safety
        public ObservableCollection<HSItem> HealthAndSafetyItems { get; set; }

        public HealthSafetyVM()
        {
            //create a list of title & description to be called upon when title and description is used on xaml page
            //prints whole list with HealthAndSafetyItems
            HealthAndSafetyItems = new ObservableCollection<HSItem>();

            HealthAndSafetyItems.Add(new HSItem
            {
                Title = "Contacts and Resources For USW",
                Description = "Local hospitals: XYZ Hospital, 123 Main St. " +
                "\nCrisis hotline: 1-800-555-5555." +
                "\nUSW Student support group: Every Monday at 1pm in Building Block X." +
                "\nCounseling services will provide confidential mental health support, your private information is safe."
            });

            HealthAndSafetyItems.Add(new HSItem
            {
                Title = "[USW] Personal Wellness",
                Description = "Make sure you have enough rest to support your physical and mental health." +
                "\nStay active with regular exercises like a jog, walk or stretching." +
                "\nMaintain a healthy diet, Vitamins and minerals are important."
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] Emergency Contacts", Description = "Health Centre: 987-654-3219" +
                "\nCampus Security: 123-456-7891" +
                "\nCounseling Contact: 888-888-8888"
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] Health Resources For Student", Description = "Student Health Centre: Building X, Room Y." +
                "\nMental Health Support: Building X, Room Y." +
                "\nCampus Shop: Building X, Room Y."
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] Safety Tips", Description = "Always double check your door is locked can never be too safe." +
                "\nIf possible avoid walking alone in the night."
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] Campus Policies", Description = "No smoking on campus site unless it's a smoking dedicated area." +
                "\nAlcohol prohibited on campus."
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] Emergency Procedures", Description = "In case of a fire, leave all belonging and evacuate the building immediately!!!" +
                "\nIn case of a medical emergency, call 911 if it's of serious matter else call Security."
            });

            HealthAndSafetyItems.Add(new HSItem { Title = "[USW] [OLD] COVID-19 Information", Description = "All students are required to be fully vaccinated against COVID-19 to stop spread." +
                "\nMasks are required indoors for all individuals, regardless of vaccination status." +
                "\nIf you test positive for COVID-19, you must quarantine for x days."
            });

        }

    }

}
