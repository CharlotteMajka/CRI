using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRICore.Model
{
    public class data
    {
        public string registration { get; set; }
        public string vin { get; set; }
        public string type { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string version { get; set; }
        public string fuel_type { get; set; }
        public string registration_status { get; set; }
        public string registration_status_updated_date { get; set; }
        public string first_registration_date { get; set; }
        public string expire_date { get; set; }
        public string status_updated_date { get; set; }
        public int model_year { get; set; }
        public int total_weight { get; set; }
        public int vehicle_weight { get; set; }
        public int technical_total_weight { get; set; }
        public bool coupling { get; set; }
        public int towing_weight { get; set; }
        public int towing_weight_brakes { get; set; }
        public int minimum_weight { get; set; }
        public int engine_power { get; set; }
        public decimal fuel_efficiency { get; set; }
        public int engine_displacement { get; set; }
        public int engine_cylinders { get; set; }
        public string engine_code { get; set; }
        public string last_inspection_date { get; set; }
        public string last_inspection_result { get; set; }
        public int last_inspection_odometer { get; set; }
        public string type_approval_code { get; set; }
        public int top_speed { get; set; }
        public int doors { get; set; }
        public int minimum_seats { get; set; }
        public int maximum_seats { get; set; }
        public string wheels { get; set; }
        public string extra_equipment { get; set; }
        public string axles { get; set; }
        public string drive_axles { get; set; }
        public string leasing_period_start { get; set; }
        public string leasing_period_end { get; set; }
        public int vehicle_id { get; set; }
        public use use { get; set; }
        public color color { get; set; }
        public body_type body_type { get; set; }
    }

    public class use 
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class color
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class body_type
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
