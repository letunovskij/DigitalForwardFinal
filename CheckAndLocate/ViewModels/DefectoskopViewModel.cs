using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheckAndLocate.ViewModels
{
    public class DefectoskopViewModel
    {
        [Display(Name = "Тег раздела")]
        public string Tag { get; set; } // VDF0
        //[Display(Name = "Размер данных (технический параметр)")]
        //public int Size { get; set; } // 112
        [Display(Name = "Время считывания (мкс)")]
        public string Time { get; set; } // 25.691270 111.181856
        [Display(Name = "Дистанция (0.01мм)")] 
        public int Dist { get; set; }
        [Display(Name = "Первый одометр")]
        public int Wheel1_v { get; set; } // технический параметр
        [Display(Name = "Второй одометр")]
        public int Wheel2_v { get; set; } // технический параметр
        [Display(Name = "Порядковый номер записи")]
        public int Index { get; set; }
        [Display(Name = "Угол поворота дефектоскопа")]
        public int Angle { get; set; }
        [Display(Name = "Флаги сканирования")]
        public string Flags { get; set; }
        [Display(Name = "Пройденный путь")]
        public string Dist_ext { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }

        public DefectoskopViewModel(string fileRow)
        {
            string[] arrayRow = fileRow.Split(',');

            this.Tag = arrayRow[0];

            //double time = 0;
            //Double.TryParse(arrayRow[2], out time);
            this.Time = arrayRow[2];//time;

            int dist = 0;
            int.TryParse(arrayRow[3], out dist);
            this.Dist = dist;

            int wheel1_v = 0;
            int.TryParse(arrayRow[4], out wheel1_v);
            this.Wheel1_v = wheel1_v;

            int wheel2_v = 0;
            int.TryParse(arrayRow[5], out wheel2_v);
            this.Wheel2_v = wheel2_v;

            int index = 0;
            int.TryParse(arrayRow[6], out index);
            this.Index = index;

            int angle = 0;
            int.TryParse(arrayRow[7], out angle);
            this.Angle = angle;

            this.Flags = arrayRow[8];

            this.Dist_ext = arrayRow[9];

            this.Status = arrayRow[10];
        }
    }
}
