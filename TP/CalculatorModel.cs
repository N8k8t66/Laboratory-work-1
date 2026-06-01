using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculatorApp.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Поле 'Первое число' обязательно для заполнения")]
        public long Operand1 { get; set; }
        [Required(ErrorMessage = "Поле 'Второе число' обязательно для заполнения")]
        [Compare("Operand1", ErrorMessage = "Второе число должно совпадать с первым числом")]
        public decimal Operand2 { get; set; }
        public string Operation { get; set; }
        public decimal result { get; set; }
    }
}
