using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_payment
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "getCustomer")]

        List<customers> getcustomer();

        [OperationContract]
 
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "postCustomer/{id}/{name}/{city}")]

       List<customers> postCustomer(string id,string name,string city);

        [OperationContract]

        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped,
           UriTemplate = "delCustomer/{id}")]

        void delCustomer(string id);

        [OperationContract]

        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped,
           UriTemplate = "putCustomer/{id}/{name}/{city}")]

        void putcustomer(string id,string name,string city);


        [OperationContract]

        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped,
           UriTemplate = "poCustomer")]

        void pocustomer(customers customer);
    }


  
}
