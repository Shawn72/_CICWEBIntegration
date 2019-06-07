using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web.Http;
using Newtonsoft.Json;
using _CICWEBIntegration.IntegrationCodeunit;
using _CICWEBIntegration.Classes;
using _CICWEBIntegration.fPASAXARPaymentJournalService;
using _CICWEBIntegration.fPASAXCustomerService;
using _CICWEBIntegration.fPASAXInvoiceJournalService;
using _CICWEBIntegration.fPASAXPaymentJournalService;
using _CICWEBIntegration.fPASAXVendorServices;

namespace _CICWEBIntegration.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
       
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        public string Get(string vendorno)
        {
            string membername = "";
            
            try
            {
                //Service1 findvendor = new Service1(); //call my SVC webservice
                //membername = findvendor.GetVendorId(vendorno);

            }
            catch (System.Exception exp)
            {
                membername = exp.Message;
               // membername = exp.StackTrace;
            }
            return membername;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //[HttpPost]
        //[Route("FnSendMemberConfirmationDetails")]
        //public string FnSendMemberConfirmationDetails([FromBody] Classes.FindCustomer value )
        //{
        //    string kraPin = value.Krapin;
        //    string postinggroup = value.Customergroup;
        //    string idNo = value.Idnumber;
        //    string customerfoundornot = new WsConfig().ObjNav.FnSendMemberConfirmationDetails(kraPin, postinggroup, idNo);
        //    return customerfoundornot;
        //}

        //[HttpPost]
        //[Route("FnCreateCustomer")]
        //public void FnCreateCustomer([FromBody] Classes.CreateCustomer value)
        //{
        //    string accountNo = value.AccountNo;
        //    string firstname = value.Firstname;
        //    string middlename = value.Middlename;
        //    string lastname = value.Lastname;
        //    string gender = value.Gender;
        //    string maritalstatus = value.Maritalstatus;
        //    string country = value.Country;
        //    string zipcode = value.Zipcode;
        //    string phonenumber = value.Phonenumber;
        //    string email = value.Email;
        //    string idnumber = value.Idnumber;
        //    string bankAccount = value.BankAccount;
        //    string bankAccountId = value.BankAccountId;
        //    string krapin = value.Krapin;
        //    string customergroup = value.Customergroup;
        //    string recordtype = value.Recordtype;

        //    BasicHttpBinding_CICFPASCustomerCreationService createnewcust = new BasicHttpBinding_CICFPASCustomerCreationService();
        //    createnewcust.createNewCustomer(accountNo, firstname, middlename, lastname, gender,
        //        maritalstatus, country, zipcode, phonenumber, email, idnumber, bankAccount,
        //        bankAccountId, krapin, customergroup, recordtype);
        //}

        //[HttpPost]
        //[Route("FnSendMemberConfirmationDetails")]
        //public string FnSendMemberConfirmationDetails([FromBody] Classes.FindCustomer value)
        //{
        //    string krapin = value.Krapin;
        //    string idnumber = value.Idnumber;
        //    string customergroup = value.Customergroup;

        //    BasicHttpBinding_CICFPASCustomerCreationService findcust = new BasicHttpBinding_CICFPASCustomerCreationService();
        //    string findresponse = findcust.findCustomer(krapin, customergroup, idnumber);
        //    return findresponse;
        //}


        //for use by Nav to find Vendor from AX
        [HttpGet]
        [Route("FnfindVendorfromAx")]
        public string FnfindVendorfromAx(string kraPin, string vendorGroup, string idNo)
        {
            string aXresponse = "";
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASVendorCreationService fpaswcf = new BasicHttpBinding_CICFPASVendorCreationService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                aXresponse = fpaswcf.findVendor(kraPin, vendorGroup, idNo);

            }
            catch (Exception ex)
            {
                aXresponse = ex.Message;
            }
            return aXresponse;
        }

        [HttpGet]
        [Route("FnCreateAvendorOnAx")]
        public string FnCreateAvendorOnAx(string accountNo, string recordType, string firstname, string physicalstreet, string zipCode, string phoneNumber, string eMailadd,
            string withholdTaxcalc, string contactStatus, string krapin, string postalStreet, string fax, string uRl, string vendorGroup, string iDno, string bankCode, string bankAccnum, string bankBranchcode)
        {
            string aXresponse = "";
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASVendorCreationService fpaswcf = new BasicHttpBinding_CICFPASVendorCreationService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
               aXresponse = fpaswcf.createNewVendor(accountNo, recordType, firstname, physicalstreet,
                   zipCode, phoneNumber, eMailadd, withholdTaxcalc, contactStatus, krapin, postalStreet, fax, uRl, vendorGroup, iDno, bankCode, bankAccnum, bankBranchcode);
                

            }
            catch (Exception ex)
            {
                aXresponse = ex.Message;
            }
            return aXresponse;
        }

        //for use by Nav to find Customer from AX
        [HttpGet]
        [Route("FnFindCustomerfromAx")]
        public string FnFindCustomerfromAx(string kraPin, string vendorGroup, string idNo)
        {
            var axResponse="";
            try
            {
                //for finding vendor from AX
                BasicHttpBinding_CICFPASCustomerCreationService fpaswcf = new BasicHttpBinding_CICFPASCustomerCreationService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                axResponse = fpaswcf.findCustomer(kraPin, vendorGroup, idNo);
            }
            catch (Exception ex)
            {

                axResponse = ex.Message;
            }
            return axResponse;
        }

        [HttpGet]
        [Route("FnCreateAcustomerOnAx")]
        public string FnCreateAcustomerOnAx(string accountNo, string fistname, string middlename, string lastname, string gender, string marritalstatus, string country,
           string zipCode, string phoneNumber, string emailAdd, string idNumber,  string bankAccnum, string bankAcciD, string krapin, string customerGroup, string recordType)
        {
            string aXresponse = "";
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASCustomerCreationService fpaswcf = new BasicHttpBinding_CICFPASCustomerCreationService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                aXresponse = fpaswcf.createNewCustomer(accountNo, fistname, middlename, lastname,
                    gender, marritalstatus, country, zipCode, phoneNumber, emailAdd, idNumber, bankAccnum, bankAcciD, krapin, customerGroup, recordType);
                
            }
            catch (Exception ex)
            {
              aXresponse = ex.Message;
            }
            return aXresponse;
        }


        //For use by Nav to create Vendor from AX
        [HttpGet]
        [Route("FnCreateVendorfromAx")]
        public string FnCreateVendorfromAx(string krapin)
        {
            //create Vendor on NAv, search from AX

            CICIntegrations ws = new CICIntegrations();
            var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
            ws.Credentials = credentials;
            ws.PreAuthenticate = true;
            ws.Timeout = -1;

            string status = "";

            // replace this code if searching from AX services;

            //var alldetails = ws.FnGetAllVendorDetails(krapin);
            //string[] onedetail = alldetails.Split(new string[] { ":::" }, StringSplitOptions.None);

            //string fullname = onedetail[0];
            //string address = onedetail[1];
            //string city = onedetail[2];
            //string phonenumber = onedetail[3];
            //string globaldimcode1 = onedetail[4];
            //string globaldimcode2 = onedetail[5];
            //string vendorpostinggroup = onedetail[6];
            //string county = onedetail[7];
            //string email = onedetail[8];
            //string idnumber = onedetail[9];
            //string maritalstatus = onedetail[10];
            //string bankaccountNo = onedetail[11];
            //string bankaccountId = onedetail[12];
            //string gender = onedetail[13];
            //string accountNo = onedetail[14];
            //string vendortype = onedetail[15];

            //VendorDetails vendor = new VendorDetails
            //{
            //    Fullname = fullname,
            //    Address = address,
            //    City = city,
            //    Phonenumber = phonenumber,
            //    Globaldimcode1 = globaldimcode1,
            //    Globaldimcode2 = globaldimcode2,
            //    Vendorpostinggroup = vendorpostinggroup,
            //    County = county,
            //    Email = email,
            //    Idnumber = idnumber,
            //    Krapin = krapin,
            //    Maritalstatus = maritalstatus,
            //    BankaccountNo = bankaccountNo,
            //    BankaccountId = bankaccountId,
            //    Gender = gender,
            //    AccountNo = accountNo,
            //    Vendortype = vendortype
            //};


            //bool inserttovendor = ws.FnCreateNavVendor(vendor.AccountNo, vendor.Fullname, vendor.Gender,
            //              vendor.Maritalstatus, vendor.County, vendor.Phonenumber,
            //              vendor.Email, vendor.Idnumber, vendor.BankaccountNo, vendor.BankaccountId, vendor.Krapin,
            //              vendor.Vendorpostinggroup, vendor.Globaldimcode1,
            //              vendor.Globaldimcode2, vendor.Address, vendor.Vendortype);

            //status = inserttovendor == true ? "Data inserted" : "Data insert failed";

            return status;
        }

        //for use by AX to find vendor from NAv
        [HttpGet]
        [Route("FnFindVendorfromNav")]
        public string FnFindVendorfromNav(string krapin)
        {
            // For use by AX to find vendor from NAV
            string membername = "";
            try
            {
                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;
                
                var navresponse = ws.FnFindVendorfromNav(krapin);
                switch (navresponse)
                {
                    case "membernumber found":
                       // membername = ws.FnGetVendorName(vendornumber);
                       // membername = membernameo.Replace('"', ' ').Trim();
                        var alldetails = ws.FnGetAllVendorDetails(krapin);
                        string[] onedetail = alldetails.Split(new string[] { ":::" }, StringSplitOptions.None);

                        string fullname = onedetail[0];
                        string address = onedetail[1];
                        string city = onedetail[2];
                        string phonenumber = onedetail[3];
                        string globaldimcode1 = onedetail[4];
                        string globaldimcode2 = onedetail[5];
                        string vendorpostinggroup = onedetail[6];
                        string county = onedetail[7];
                        string email = onedetail[8];
                        string idnumber = onedetail[9];
                        string maritalstatus = onedetail[10];
                        string bankaccountNo = onedetail[11];
                        string bankaccountId = onedetail[12];
                        string gender = onedetail[13];
                        string accountNo = onedetail[14];
                        string vendortype = onedetail[15];

                        VendorDetails vendor = new VendorDetails
                        {
                            Fullname = fullname,
                            Address = address,
                            City = city,
                            Phonenumber = phonenumber,
                            Globaldimcode1 = globaldimcode1,
                            Globaldimcode2 = globaldimcode2,
                            Vendorpostinggroup = vendorpostinggroup,
                            County = county,
                            Email = email,
                            Idnumber = idnumber,
                            Krapin = krapin,
                            Maritalstatus = maritalstatus,
                            BankaccountNo = bankaccountNo,
                            BankaccountId = bankaccountId,
                            Gender = gender,
                            AccountNo = accountNo,
                            Vendortype = vendortype
                        };

                        string json = JsonConvert.SerializeObject(vendor, Formatting.None);
                        string outputjson = json.Replace(@"\", "");

                        //returns json with Nav vendor details
                         membername = outputjson;

                        break;
                    case "membernumber not found":
                        // AX to
                        membername = navresponse;
                        break;
                }
            }
            catch (TimeoutException timeProblem)
            {
                membername = timeProblem.Message;
            }
            catch (FaultException myCustomFault)
            {
                membername = myCustomFault.Message;
            }
            catch (CommunicationException commProblem)
            {
                membername = commProblem.Message;
            }
            return membername;
        }

        //for use by AX to save to NAv
        [HttpGet]
        [Route("FnCreateVendorOnNav")]
        public string FnCreateVendorOnNav(string krapin)
        {
            //Function used to test if API is posting to NAV: tested OK
            // For use by AX to find vendor from NAV
            string membername = "";
            try
            {
                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;

                var navresponse = ws.FnFindVendorfromNav(krapin);
                switch (navresponse)
                {
                    case "membernumber found":
                        // membername = ws.FnGetVendorName(vendornumber);
                        // membername = membernameo.Replace('"', ' ').Trim();
                        var alldetails = ws.FnGetAllVendorDetails(krapin);
                        string[] onedetail = alldetails.Split(new string[] { ":::" }, StringSplitOptions.None);

                        string fullname = onedetail[0];
                        string address = onedetail[1];
                        string city = onedetail[2];
                        string phonenumber = onedetail[3];
                        string globaldimcode1 = onedetail[4];
                        string globaldimcode2 = onedetail[5];
                        string vendorpostinggroup = onedetail[6];
                        string county = onedetail[7];
                        string email = onedetail[8];
                        string idnumber = onedetail[9];
                        string maritalstatus = onedetail[10];
                        string bankaccountNo = onedetail[11];
                        string bankaccountId = onedetail[12];
                        string gender = onedetail[13];
                        string accountNo = onedetail[14];
                        string vendortype = onedetail[15];

                        VendorDetails vendor = new VendorDetails
                        {
                            Fullname = fullname,
                            Address = address,
                            City = city,
                            Phonenumber = phonenumber,
                            Globaldimcode1 = globaldimcode1,
                            Globaldimcode2 = globaldimcode2,
                            Vendorpostinggroup = vendorpostinggroup,
                            County = county,
                            Email = email,
                            Idnumber = idnumber,
                            Krapin = krapin,
                            Maritalstatus = maritalstatus,
                            BankaccountNo = bankaccountNo,
                            BankaccountId = bankaccountId,
                            Gender = gender,
                            AccountNo = accountNo,
                            Vendortype = vendortype
                        };

                        bool inserttovendor = ws.FnCreateNavVendor(vendor.AccountNo, vendor.Fullname, vendor.Gender,
                        vendor.Maritalstatus, vendor.County, vendor.Phonenumber,
                        vendor.Email, vendor.Idnumber, vendor.BankaccountNo, vendor.BankaccountId, vendor.Krapin,
                        vendor.Vendorpostinggroup, vendor.Globaldimcode1,
                        vendor.Globaldimcode2, vendor.Address, vendor.Vendortype);

                        membername = inserttovendor == true ? "Data inserted" : "Data insert failed";

                        break;
                    case "membernumber not found":
                        // AX to
                        membername = navresponse;
                        break;
                }
            }
            catch (TimeoutException timeProblem)
            {
                membername = timeProblem.Message;
            }
            catch (FaultException myCustomFault)
            {
                membername = myCustomFault.Message;
            }
            catch (CommunicationException commProblem)
            {
                membername = commProblem.Message;
            }
            return membername;
        }
        
        //Below code used to test the WebApi on NAv,...replica of the above functions
        [HttpGet]
        [Route("FnfindVendorfromNavTest")]
        public string FnfindVendorfromNavTest(string krapin)
        {
            string apiresponse = "";
            try
            {
                //Service1 findvendor = new Service1(); //call my SVC webservice
                // navresponse = findvendor.GetVendorId(vendorNo);

                //Nav Test pushing data to staging table

                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;

                 var navresponse = ws.FnFindVendorfromNav(krapin);
                switch (navresponse)
                {
                    case "membernumber found":
                        apiresponse = "found";
                        break;
                    case "membernumber not found":
                        apiresponse = "notfound";
                        break;
                }
            }
            catch (Exception ex)
            {
                apiresponse = ex.Message;
            }
            return apiresponse;
        }

        [HttpGet]
        [Route("FnCreateTestVendorNav")]
        public string FnCreateTestVendorNav(string krapin)
        {
            //Function used to test if API is posting to NAV: tested OK
            // For use by AX to find vendor from NAV
            string membername = "";
            try
            {
                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;

                var navresponse = ws.FnFindVendorfromNav(krapin);
                switch (navresponse)
                {
                    case "membernumber found":
                        // membername = ws.FnGetVendorName(vendornumber);
                        // membername = membernameo.Replace('"', ' ').Trim();
                        var alldetails = ws.FnGetAllVendorDetails(krapin);
                        string[] onedetail = alldetails.Split(new string[] { ":::" }, StringSplitOptions.None);

                        string fullname = onedetail[0];
                        string address = onedetail[1];
                        string city = onedetail[2];
                        string phonenumber = onedetail[3];
                        string globaldimcode1 = onedetail[4];
                        string globaldimcode2 = onedetail[5];
                        string vendorpostinggroup = onedetail[6];
                        string county = onedetail[7];
                        string email = onedetail[8];
                        string idnumber = onedetail[9];
                        string maritalstatus = onedetail[10];
                        string bankaccountNo = onedetail[11];
                        string bankaccountId = onedetail[12];
                        string gender = onedetail[13];
                        string accountNo = onedetail[14];
                        string vendortype = onedetail[15];

                        VendorDetails vendor = new VendorDetails
                        {
                            Fullname = fullname,
                            Address = address,
                            City = city,
                            Phonenumber = phonenumber,
                            Globaldimcode1 = globaldimcode1,
                            Globaldimcode2 = globaldimcode2,
                            Vendorpostinggroup = vendorpostinggroup,
                            County = county,
                            Email = email,
                            Idnumber = idnumber,
                            Krapin = krapin,
                            Maritalstatus = maritalstatus,
                            BankaccountNo = bankaccountNo,
                            BankaccountId = bankaccountId,
                            Gender = gender,
                            AccountNo = accountNo,
                            Vendortype= vendortype
                        };

                            bool inserttovendor = ws.FnCreateNavVendor(vendor.AccountNo, vendor.Fullname, vendor.Gender,
                            vendor.Maritalstatus, vendor.County, vendor.Phonenumber,
                            vendor.Email, vendor.Idnumber, vendor.BankaccountNo, vendor.BankaccountId, vendor.Krapin,
                            vendor.Vendorpostinggroup, vendor.Globaldimcode1,
                            vendor.Globaldimcode2, vendor.Address, vendor.Vendortype);

                            membername = inserttovendor == true ? "Data inserted" : "Data insert failed";
                        
                        break;
                    case "membernumber not found":
                        // AX to
                        membername = navresponse;
                        break;
                }
            }
            catch (TimeoutException timeProblem)
            {
                membername = timeProblem.Message;
            }
            catch (FaultException myCustomFault)
            {
                membername = myCustomFault.Message;
            }
            catch (CommunicationException commProblem)
            {
                membername = commProblem.Message;
            }
            return membername;
        }

        [HttpGet]
        [Route("FnPostInvoiceJournalOnAx")]
        public string FnPostInvoiceJournalOnAx(string journalType, DateTime tranxTime, bool tranxDatespecified, string ledgerAccount, string dimensions, string invoice, string description,
             decimal amountDebit, bool amtDebitspecified, decimal amountCredit, bool amtCreditspecified, string offsetAccount, string offsetDimensions, string methodofPayment)
        {
            string aXresponse = "";
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASAPInvoiceJournalService fpaswcf = new BasicHttpBinding_CICFPASAPInvoiceJournalService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                aXresponse = fpaswcf.createInvoiceJournal(journalType, tranxTime, tranxDatespecified, ledgerAccount,
                    dimensions, invoice, description, amountDebit, amtDebitspecified, amountCredit, amtCreditspecified, offsetAccount, offsetDimensions, methodofPayment);

            }
            catch (Exception ex)
            {
                aXresponse = ex.Message;
            }
            return aXresponse;
        }

        [HttpGet]
        [Route("FnPostArPaymentJournalOnAx")]
        public void FnPostArPaymentJournalOnAx(string journalType, DateTime tranxTime, bool tranxDatespecified, string ledgerAccount, string dimensions, string invoice, string description,
             decimal amountDebit, bool amtDebitspecified, decimal amountCredit, bool amtCreditspecified, string offsetAccount, string offsetDimensions, string methodofPayment)
        {
          //  string[]aXresponse;
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASARPaymentJournalService fpaswcf = new BasicHttpBinding_CICFPASARPaymentJournalService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                fpaswcf.sendPaymentJournal();
                
            }
            catch (Exception ex)
            {
                //aXresponse[] = ex.Message;
            }
            //return null;
        }


        [HttpGet]
        [Route("FnPostApPaymentJournalOnAx")]
        public void FnPostApPaymentJournalOnAx(string journalType, DateTime tranxTime, bool tranxDatespecified, string ledgerAccount, string dimensions, string invoice, string description,
             decimal amountDebit, bool amtDebitspecified, decimal amountCredit, bool amtCreditspecified, string offsetAccount, string offsetDimensions, string methodofPayment)
        {
            //  string[]aXresponse;
            try
            {
                //use AX services or API to find if the Vendor exists from  AX table,  for live API

                //call my SVC webservice for testing

                //for finding vendor from AX
                BasicHttpBinding_CICFPASAPPaymentJournalService fpaswcf = new BasicHttpBinding_CICFPASAPPaymentJournalService();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                fpaswcf.Credentials = credentials;
                fpaswcf.PreAuthenticate = true;
                fpaswcf.Timeout = -1;
                fpaswcf.sendPaymentJournal();

            }
            catch (Exception ex)
            {
                //aXresponse[] = ex.Message;
            }
            //return null;
        }


        [HttpGet]
        [Route("FnCreateFindTestCustomeronAx")]
        public string FnCreateFindTestCustomeronAx(string krapin)
        {
            //Function used to test if API is posting to NAV: tested OK
            // For use by AX to find vendor from NAV
            string response = "";
            try
            {
                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;
                string allnavresponse = ws.FnGetCustomerDetailsfromNav(krapin);

                string[] onedetail = allnavresponse.Split(new string[] { ":::" }, StringSplitOptions.None);

                string accountNu = onedetail[0];
                string firstname = onedetail[1];
                string midname = onedetail[2];
                string lastname = onedetail[3];
                string maritalstaus = onedetail[4];
                string contry = onedetail[5];
                string zipcode = onedetail[6];
                string phonenumber = onedetail[7];
                string email = onedetail[8];
                string bankaccountNo = onedetail[9];
                string bankaccountId = onedetail[10];
                string schemkrapin = onedetail[11];
                string  custpostinggrp= onedetail[12];
                string recordtype = onedetail[13];
                string idnum = onedetail[14];
                string genders = onedetail[15];
                CustomerDetails customer = new CustomerDetails
                {
                    AccountNo = accountNu,
                    Firstname = firstname,
                    Middname = midname,
                    Lastname = lastname,
                    Gender = genders,
                    Maritalstatus = maritalstaus,
                    County = contry,
                    Zipcode = zipcode,
                    Phonenumber = phonenumber,
                    Email = email,
                    Idnumber = idnum,
                    BankaccountNo = bankaccountNo,
                    BankaccountId = bankaccountId,
                    Krapin = schemkrapin,
                    Customerpostinggroup = custpostinggrp,
                    Recordtype = recordtype
                };
                string json = JsonConvert.SerializeObject(customer, Formatting.None);
                string outputjson = json.Replace(@"\", "");

                //returns json with Nav vendor details
                response = outputjson;

            }
            catch (TimeoutException timeProblem)
            {
                response = timeProblem.Message;
            }
            catch (FaultException myCustomFault)
            {
                response = myCustomFault.Message;
            }
            catch (CommunicationException commProblem)
            {
                response = commProblem.Message;
            }
            return response;
        }

        [HttpGet]
        [Route("FnGetPvDetailsfromNav")]
        public string FnGetPvDetailsfromNav(string pvnumber, string journaltype)
        {
            //Function used to test if API is posting to NAV: tested OK
            // For use by AX to find vendor from NAV
            string response = "";
            try
            {
                CICIntegrations ws = new CICIntegrations();
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                ws.Credentials = credentials;
                ws.PreAuthenticate = true;
                ws.Timeout = -1;
                string allnavresponse = ws.FnReturnPaymentJournalDetails(pvnumber, journaltype);

                string[] onedetail = allnavresponse.Split(new string[] { ":::" }, StringSplitOptions.None);

                string journalType = onedetail[0];
                string tranxTime = onedetail[1];
                string tranxDatespecified = onedetail[2];
                string ledgerAccount = onedetail[3];
                string dimensions = onedetail[4];
                string invoice = onedetail[5];
                string description = onedetail[6];
                string amountDebit = onedetail[7];
                string amtDebitspecified = onedetail[8];
                string amountCredit = onedetail[9];
                string amtCreditspecified = onedetail[10];
                string offsetAccount = onedetail[11];
                string offsetDimensions = onedetail[12];
                string methodofPayment = onedetail[13];

                PvDetails pvdetails = new PvDetails
                {
                    JournalType = journalType,
                    TranxTime = tranxTime,
                    TranxDatespecified = tranxDatespecified,
                    LedgerAccount = ledgerAccount,
                    Dimensions = dimensions,
                    Invoice = invoice,
                    Description = description,
                    AmountDebit = amountDebit,
                    AmtDebitspecified = amtDebitspecified,
                    AmountCredit = amountCredit,
                    AmtCreditspecified = amtCreditspecified,
                    OffsetAccount = offsetAccount,
                    OffsetDimensions = offsetDimensions,
                    MethodofPayment = methodofPayment,
                };
                string json = JsonConvert.SerializeObject(pvdetails, Formatting.None);
                string outputjson = json.Replace(@"\", "");

                //returns json with Nav vendor details
                response = outputjson;

            }
            catch (TimeoutException timeProblem)
            {
                response = timeProblem.Message;
            }
            catch (FaultException myCustomFault)
            {
                response = myCustomFault.Message;
            }
            catch (CommunicationException commProblem)
            {
                response = commProblem.Message;
            }
            return response;
        }
    }
}
