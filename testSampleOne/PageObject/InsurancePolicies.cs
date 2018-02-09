using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testSampleOne.PageObject
{
    class InsurancePolicies
    {
        private By InsurancePolicyMenu = By.XPath("//a[text()=' Insurance policies']");
        private By NewBtn = By.XPath("//button[text()='New']");
        private By InsurancePolicyName = By.XPath("//div/input[@placeholder='Insurance policy']");
        private By DoneBtn = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Insurance policy']]//button[text()='Done']");

        public By GetInsurancePolicyMenu()
        {
            return InsurancePolicyMenu;
        }

        public By GetNewBtn()
        {
            return NewBtn;
        }

        public By GetInsurancePolicyName()
        {
            return InsurancePolicyName;
        }

        public By GetDoneBtn()
        {
            return DoneBtn;
        }

    }
}
