using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataGrid.Models;

namespace DataGrid
{
    public class CustomerDataGenerator
    {
        public List<string> FirstNameList { get; private set; }
        public List<string> LastNameList { get; private set; }
        public List<string> PositionList { get; private set; }
        public List<string> OfficeList { get; private set; }
        public List<DateTime> StartDateList { get; private set; }
        public List<decimal> SalaryList { get; private set; }

        public List<CustomerModel> GenerateCustomerList(int start, int length, int playWith)
        {

            if (HttpContext.Current.Session["customers"] != null)
            {
                var list = HttpContext.Current.Session["customers"] as List<CustomerModel>;

                if (list.Count == playWith)
                {
                    return list.Skip(start).Take(length).ToList();
                }
            }
            var customerList = new List<CustomerModel>();
            FirstNameList = new List<string>();

            FirstNameList.Add("Mustafa");
            FirstNameList.Add("Ali");
            FirstNameList.Add("Veli");
            FirstNameList.Add("Hakkı");
            FirstNameList.Add("Siraç");
            FirstNameList.Add("Veli");
            FirstNameList.Add("Muhammed");
            FirstNameList.Add("Cetin");
            FirstNameList.Add("Kadir");
            FirstNameList.Add("Serap");
            FirstNameList.Add("Selin");
            FirstNameList.Add("Mehtap");
            FirstNameList.Add("Dursun");
            FirstNameList.Add("Selami");
            FirstNameList.Add("Yavuz");

            LastNameList = new List<string>();
            LastNameList.Add("Korkmaz");
            LastNameList.Add("Kayak");
            LastNameList.Add("Yılmaz");
            LastNameList.Add("Gönenç");
            LastNameList.Add("Türkoglu");
            LastNameList.Add("Eskir");
            LastNameList.Add("Kose");
            LastNameList.Add("Solmaz");
            LastNameList.Add("Turhanlı");
            LastNameList.Add("Tavlı");
            LastNameList.Add("Bozkurt");
            LastNameList.Add("Yıldırım");
            LastNameList.Add("Tatar");
            LastNameList.Add("Kırkıl");
            LastNameList.Add("Cetin");

            PositionList = new List<string>();
            PositionList.Add("Müdür");
            PositionList.Add("Yönetici");
            PositionList.Add("Uzman");
            PositionList.Add("Yetkili");
            PositionList.Add("Tasarımcı");
            PositionList.Add("CEO");
            PositionList.Add("CFO");

            OfficeList = new List<string>();
            OfficeList.Add("Soma");
            OfficeList.Add("Kırkagac");
            OfficeList.Add("Akhisar");
            OfficeList.Add("Salihli");
            OfficeList.Add("Demirci");
            OfficeList.Add("Alaşehir");
            OfficeList.Add("Saruhanlı");
            OfficeList.Add("Golmarmara");


            StartDateList = new List<DateTime>();
            for (int i = 0; i < 20; i++)
            {
                StartDateList.Add(DateTime.Now.AddDays((i + 1) * (-10)));
            }

            SalaryList = new List<decimal>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var d = random.NextDouble() * (500 - 100) + 100;
                SalaryList.Add(Convert.ToDecimal(Math.Round(d, 2)));
            }
            for (int i = 0; i < playWith; i++)
            {
                var firstName = FirstNameList[random.Next(0, 14)];
                var lastName = LastNameList[random.Next(0, 14)];
                var position = PositionList[random.Next(0, 6)];
                var office = OfficeList[random.Next(0, 7)];
                var startDate = StartDateList[random.Next(0, 19)].ToShortDateString();
                var salary = SalaryList[random.Next(0, 19)];

                customerList.Add(new CustomerModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Position = position,
                    Office = office,
                    Salary = salary,
                    StartDate = startDate
                });
            }
            HttpContext.Current.Session["customers"] = customerList;
            return customerList.Skip(start).Take(length).ToList();
        }
    }
}

