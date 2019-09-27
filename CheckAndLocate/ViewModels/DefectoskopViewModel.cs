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
        public double Time { get; set; } // 25.691270 111.181856
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

    }
}
