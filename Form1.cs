using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDF1
{
    // --- 1. İLK OLARAQ FORM1 SINFİ GƏLMƏLİDİR (Dizayn xatası yox olması üçün) ---
    public partial class Form1 : Form
    {
        EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtIsciKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsciSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsciYas_TextChanged(object sender, EventArgs e)
        {

        }

        // İŞÇİ ƏLAVƏ ET DÜYMƏSİ
        private void addBtn_Click(object sender, EventArgs e)
        {
            string code = txtIsciKodu.Text.Trim();
            string firstName = txtIsciAd.Text.Trim();
            string lastName = txtIsciSoyad.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIsciYas.Text.Trim(), out int age))
            {
                MessageBox.Show("Yaş düzgün daxil edilməyib!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee newEmp = new Employee
            {
                Code = code,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            bool success = service.AddEmployee(newEmp);
            if (success)
            {
                MessageBox.Show("İşçi uğurla əlavə olundu!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIsciKodu.Clear();
                txtIsciAd.Clear();
                txtIsciSoyad.Clear();
                txtIsciYas.Clear();
            }
            else
            {
                MessageBox.Show("Bu koda malik işçi artıq mövcuddur!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtIsciKodu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMebleg_TextChanged(object sender, EventArgs e)
        {

        }

        // ÖDƏNİŞ ƏLAVƏ ET DÜYMƏSİ
        private void addBtn2_Click(object sender, EventArgs e)
        {
            string code = txtIsciKodu2.Text.Trim();
            string title = txtPayment.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(title))
            {
                MessageBox.Show("İşçi kodu və ödəniş adı boş ola bilməz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtMebleg.Text.Trim(), out double amount))
            {
                MessageBox.Show("Məbləğ düzgün daxil edilməyib!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = service.AddPayment(code, title, amount);
            if (success)
            {
                MessageBox.Show("Ödəniş uğurla əlavə olundu!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIsciKodu2.Clear();
                txtPayment.Clear();
                txtMebleg.Clear();
            }
            else
            {
                MessageBox.Show("İşçi tapılmadı və ya məbləğ 0-dan böyük deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        // STATİSTİKA - İŞÇİ KODUNA GÖRƏ AXTARIŞ
        private void txtIsciKodu3_TextChanged(object sender, EventArgs e)
        {
            string code = txtIsciKodu3.Text.Trim();
            listBox2.Items.Clear();

            if (string.IsNullOrEmpty(code))
            {
                return;
            }

            var emp = service.FindEmployee(code);
            if (emp == null)
            {
                return;
            }

            listBox2.Items.Add($"Kod: {emp.Code}");
            listBox2.Items.Add($"Ad: {emp.FirstName}");
            listBox2.Items.Add($"Soyad: {emp.LastName}");
            listBox2.Items.Add($"Yaş: {emp.Age}");
            listBox2.Items.Add("--------------------------------");
            listBox2.Items.Add("Ödənişlər:");

            if (emp.Payments.Count == 0)
            {
                listBox2.Items.Add("Heç bir ödənişi yoxdur.");
            }
            else
            {
                foreach (var p in emp.Payments)
                {
                    listBox2.Items.Add($"-> {p.Title} : {p.Amount} AZN");
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    // --- 2. DIGƏR SİNİFLƏR İNDİ AŞAĞIDA YERLƏŞİR ---
    public class Employee
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }

    public class Payment
    {
        public string Title { get; set; }
        public double Amount { get; set; }
    }

    public abstract class EmployeeServiceBase
    {
        public abstract bool AddEmployee(Employee employee);
        public abstract Employee FindEmployee(string code);
        public abstract bool AddPayment(string employeeCode, string title, double amount);
        public abstract List<Payment> GetEmployeePayments(string employeeCode);
        public abstract List<Employee> GetAllEmployees();
    }

    public class EmployeeService : EmployeeServiceBase
    {
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            if (FindEmployee(employee.Code) != null)
            {
                return false;
            }
            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            return Employees.FirstOrDefault(e => e.Code == code);
        }

        public override bool AddPayment(string employeeCode, string title, double amount)
        {
            var emp = FindEmployee(employeeCode);
            if (emp == null || amount <= 0)
            {
                return false;
            }
            emp.Payments.Add(new Payment { Title = title, Amount = amount });
            return true;
        }

        public override List<Payment> GetEmployeePayments(string employeeCode)
        {
            var emp = FindEmployee(employeeCode);
            if (emp == null)
            {
                return null;
            }
            return emp.Payments;
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}