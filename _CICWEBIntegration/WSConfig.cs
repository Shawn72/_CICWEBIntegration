using System;
using System.Configuration;
using System.Net;
using _CICWEBIntegration.fPASAXCustomerService;
using _CICWEBIntegration.fPASAXVendorServices;
using _CICWEBIntegration.IntegrationCodeunit;
using _CICWEBIntegration.OData;

namespace _CICWEBIntegration
{
    public class WsConfig
    {

        public static NAV Nav = new NAV(new Uri(ConfigurationManager.AppSettings["ODATA_URI"]))
        {
            Credentials =
                new NetworkCredential(ConfigurationManager.AppSettings["W_USER"],
                    ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"])
        };
        public  static CICIntegrations ObjNav
        {
            get
            {
                CICIntegrations ws = new CICIntegrations();
                try
                {
                    var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                    ws.Credentials = credentials;
                    ws.PreAuthenticate = true;
                    ws.Timeout = -1;
                }
                catch (Exception ex)
                {
                    ex.Data.Clear();
                }
                return ws;
            }
        }

        public static BasicHttpBinding_CICFPASVendorCreationService ObjFPasVendor
        {
            get
            {
                BasicHttpBinding_CICFPASVendorCreationService fpaswcf = new BasicHttpBinding_CICFPASVendorCreationService();
                try
                {
                    var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                    fpaswcf.Credentials = credentials;
                    fpaswcf.PreAuthenticate = true;
                    fpaswcf.Timeout = -1;
                }
                catch (Exception ex)
                {
                    ex.Data.Clear();
                }
                return fpaswcf;
            }
        }
        public static BasicHttpBinding_CICFPASCustomerCreationService ObjFPasCustomer
        {
            get
            {
                BasicHttpBinding_CICFPASCustomerCreationService fpaswcf = new BasicHttpBinding_CICFPASCustomerCreationService();
                try
                {
                    var credentials = new NetworkCredential(ConfigurationManager.AppSettings["WCF_USER"], ConfigurationManager.AppSettings["WCF_PWD"], ConfigurationManager.AppSettings["WCF_DOMAIN"]);
                    fpaswcf.Credentials = credentials;
                    fpaswcf.PreAuthenticate = true;
                    fpaswcf.Timeout = -1;
                }
                catch (Exception ex)
                {
                    ex.Data.Clear();
                }
                return fpaswcf;
            }
        }
    }
}