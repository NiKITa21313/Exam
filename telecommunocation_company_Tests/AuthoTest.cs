using HashPAsswords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Controls;
using telecommunication_company.Model;
using telecommunication_company.Pages;

namespace telecommunocation_company_Tests
{
    [TestClass]
    public class AuthoTest
    {
        [TestMethod]
        public void TestGenerateCapcha() //С корректными данными
        {
            int length = 5;
            Autho autho = new Autho();
            string capcha = autho.GetCaptcha(length);
            Assert.AreEqual(length, capcha.Length);
        }

        [TestMethod]
        public void HashPasswordReturnsCorrectHash()
        {
            string password = "admin123";
            string expectedHash = "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9";
            string actualHash = HashPassvord.HashPassword(password);

            Assert.AreEqual(expectedHash, actualHash);
        }

        [TestMethod]
        public void SuccesfullyValidTesting() //Корректный
        {
            Sotrudniki sotrudniki = new Sotrudniki()
            {
                Familiya = "Test",
                Imya = "Test",
                Otchestvo = "Test",
                Adres = "Test",
                Nomer_telefona = "8(999)-999-99-99",
                Data_rojdeniya = DateTime.Now,
                ID_doljnosti = 1,
                id_pasporta = 1,
                ID_usera = 3,
                Pochta = "jasld@gmail.com"           
            };
            var contextSotr = new ValidationContext(sotrudniki);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            Assert.IsTrue(Validator.TryValidateObject(sotrudniki, contextSotr, results, true));
        }
        [TestMethod]
        public void TestSuccessfulLogin()
        {
            Autho autho = new Autho();
            autho.txtbLogin.Text = "admin";
            autho.pswbPassword.Password = "12345";

            autho.btnEnter_Click(null, null);

            Assert.AreEqual("Введите пароль для подтверждения", autho.txtLogin.Text);

        }

        [TestMethod]
        public void TestCaptchaDisplayAfterMaxAttempts()
        {
            Autho autho = new Autho();
            autho.txtbLogin.Text = "admin";
            autho.pswbPassword.Password = "123456";
            autho.btnEnter_Click(null, null);
            autho.txtbLogin.Text = "admin";
            autho.pswbPassword.Password = "123478945";
            autho.btnEnter_Click(null, null);
            Assert.IsTrue(autho.txtboxCaptcha.Visibility == Visibility.Visible);
            // Добавьте дополнительные проверки по мере необходимости
        }

        [TestMethod]
        public void TestCaptchaComparison()
        {
            Autho autho = new Autho();
            autho.txtboxCaptcha.Text = "correct_captcha"; // Задайте правильный текст капчи
            autho.txtBlockCaptcha.Text = "correct_captcha";

            autho.btnEnter_Click(null, null);

            Assert.IsTrue(autho.btnEnter.Content.ToString() == "Войти");

        }


    }
}
