using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Models
{
    public class Hire
    {
        [Key]
        public int HireId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="Введіть будь ласка Ваше повне ім'я")]
        [DisplayName("ПІБ клієнта")]
        public string FullNameClient { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Серія та номер паспорта")]
        public string ClientCode { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Домашня адреса")]
        public string ClientAddress { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Введіть будь ласка Ваш мобільний телефон")]
        [DisplayName("Контактний телефон")]
        public string ClientPhone { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Введіть будь ласка назву товару")]
        [DisplayName("Назва товару")]
        public string NameGoods { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Опис товару")]
        public string DescriptionGoods { get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "Введіть будь ласка ціну товару")]
        [DisplayName("Ціна товару")]
        public int PriceGoods { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Дата видачі")]
        public DateTime DateIssue { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Дата повернення")]
        public DateTime DateReturn { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Вартість прокату за добу")]
        public int PriceHireOnDay { get; set; }
    }
}
