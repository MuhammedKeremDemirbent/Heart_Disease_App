using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Disease_App.Model
{
    internal class modelInput
    {
       
        public float gender { get; set; }

        public float dataset_cleveland { get; set; }
        public float dataset_hungary { get; set; }
        public float dataset_switzerland { get; set; } 
        public float cp_asymptomatic { get; set; }      
        public float fbs_false { get; set; }     
        public float restecg_lv_hypertrophy { get; set; }
        public float age { get; set; }
        public float trestbps { get; set; }
        public float restecg_normal { get; set; }
        public float thalch { get; set; }

    }
}
