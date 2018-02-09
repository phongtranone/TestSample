using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatInsurancePolicy
    {
        Common common = new Common();
        InsurancePolicies InsurancePoliciesPage = new InsurancePolicies();

        public void RunTest()
        {
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            common.Login();
            //common.Login(common.UsernameLocator, common.UsernameValue, common.PasswordLocator, common.PasswordValue, common.RememberMeLocator, common.LoginBtnLocator);
            common.ClickOnElement(common.Hambuger);
            common.ClickOnElement(InsurancePoliciesPage.GetInsurancePolicyMenu());
            common.WaitLoad(2000);
            common.ClickOnElement(InsurancePoliciesPage.GetNewBtn());
            common.WaitLoad(2000);
            common.InputData(InsurancePoliciesPage.GetInsurancePolicyName(),"Insurance Policy name " + common.GetCurrentDate);
            common.ClickOnElement(InsurancePoliciesPage.GetDoneBtn());
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
