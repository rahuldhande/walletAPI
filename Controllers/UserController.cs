using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WalletAPI.Data;
using WalletAPI.Models;

namespace WalletAPI.Controllers
{ //[Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        #region Dependencies

        ppiDbLiveEntities dbContext = new ppiDbLiveEntities();
        //Authentication auth = new Authentication();


        SuccessResponse objResponse = new SuccessResponse();

        #endregion









        //#region User Order Details

        ///// <summary>
        ///// To insertOrder Details.
        ///// </summary>
        ///// <param name="objOrderDetailsViewModel"></param>
        ///// <returns></returns>
        //[HttpPost]
        ////[Authorize]
        //[Route("api/User/AddOrderDetails")]
        //public HttpResponseMessage AddOrderDetails(OrderDetailsViewModel objOrderDetailsViewModel)
        //{

        //    try
        //    {
        //        OrderDetails objOrderDetails = new OrderDetails();
        //        string mobileNumber = objOrderDetailsViewModel.Retailer_Mobile;
        //        //get mobileNumber from user table
        //        var number = (from user in dbContext.UserInfo where user.MobileNumber == mobileNumber select user).FirstOrDefault();
        //        if (number != null)
        //        {
        //            //objOrderDetails.Order_Id = objOrderDetailsViewModel.Order_Id;
        //            objOrderDetails.Retailer_Id = objOrderDetailsViewModel.Retailer_Id;
        //            objOrderDetails.Retailer_Mobile = objOrderDetailsViewModel.Retailer_Mobile;
        //            objOrderDetails.Totalprice = objOrderDetailsViewModel.Totalprice;
        //            objOrderDetails.AmountToPayOnline = objOrderDetailsViewModel.AmountToPayOnline;
        //            objOrderDetails.WalletCurrentBalance = objOrderDetailsViewModel.WalletCurrentBalance;

        //            objOrderDetails.Payment_Mode = objOrderDetailsViewModel.Payment_Mode;
        //            objOrderDetails.OrderDate = DateTime.Now;
        //            //objOrderDetails.OrderDate = !string.IsNullOrEmpty(objOrderDetailsViewModel.OrderDate) ? Convert.ToDateTime(objOrderDetailsViewModel.OrderDate) : (DateTime?)null;
        //            objOrderDetails.Shipping_Address_Id = objOrderDetailsViewModel.Shipping_Address_Id;
        //            objOrderDetails.Order_Status = objOrderDetailsViewModel.Order_Status;
        //            objOrderDetails.SAP_Order_ID = "12345";
        //            objOrderDetails.GeoCoordinates = objOrderDetailsViewModel.GeoCoordinates;
        //            objOrderDetails.Rzp_Order_Id = objOrderDetailsViewModel.Rzp_Order_Id;
        //            objOrderDetails.Rzp_Payment_Id = objOrderDetailsViewModel.Rzp_Payment_Id;
        //            objOrderDetails.Rzp_Signature = objOrderDetailsViewModel.Rzp_Signature;
        //            objOrderDetails.Rzp_Payment_Status = "Paid";


        //            dbContext.OrderDetails.Add(objOrderDetails);
        //            var i = dbContext.SaveChanges();
        //            int OrderId = objOrderDetails.Order_Id; // Get OrderId After Save Changes
        //            if (i != 0)
        //            {
        //                objOrderDetailsViewModel.Order_Id = Convert.ToString(OrderId);
        //                AddOrderProductDetail(objOrderDetailsViewModel);
        //                string message = "Your Order Is received";
        //                objCommonClasses.SendSMS(mobileNumber, message);
        //                if (objOrderDetailsViewModel.Payment_Mode == "Pay Online")
        //                {

        //                    Dictionary<string, object> input = new Dictionary<string, object>();
        //                    input.Add("amount", Convert.ToDouble(objOrderDetailsViewModel.Totalprice) * 100); // this amount should be same as transaction amount
        //                    input.Add("currency", "INR");
        //                    input.Add("receipt", objOrderDetailsViewModel.Order_Id);
        //                    input.Add("payment_capture", 1);

        //                    string key = "rzp_test_rGmx3fJtAsO7Nq";
        //                    string secret = "tuivsSqAlQZcI9MACQWQ6F46";

        //                    RazorpayClient client = new RazorpayClient(key, secret);
        //                    Razorpay.Api.Order order = client.Order.Create(input);
        //                    //var razorPayOrderId= JsonConvert.SerializeObject(order.Attributes.id);
        //                    //var razorPayReceipt = JsonConvert.SerializeObject(order.Attributes.receipt);

        //                    //object a = razorPayOrderId + razorPayReceipt;
        //                    return Request.CreateResponse(HttpStatusCode.OK, order);

        //                }

        //                else
        //                {
        //                    objResponse.Message = objOrderDetailsViewModel.Totalprice;
        //                    return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //                }



        //            }
        //            else
        //            {
        //                objResponse.Message = "Failed";
        //                return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //            }

        //        }
        //        else
        //        {
        //            objResponse.Message = "Mobile number not exists.";

        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Info(Convert.ToString(ex.InnerException));
        //        Log.Info(ex.Message);

        //        OrderErrorLogDetails objOrderErrorLogDetails = new OrderErrorLogDetails();
        //        objOrderErrorLogDetails.Retailer_Id = objOrderDetailsViewModel.Retailer_Id;
        //        objOrderErrorLogDetails.Retailer_Mobile = objOrderDetailsViewModel.Retailer_Mobile;
        //        objOrderErrorLogDetails.PaymentMode = objOrderDetailsViewModel.Payment_Mode;
        //        objOrderErrorLogDetails.Total_Price = objOrderDetailsViewModel.Totalprice;
        //        objOrderErrorLogDetails.Qty = objOrderDetailsViewModel.Qty;
        //        //objOrderErrorLogDetails.Csv_File =;
        //        objOrderErrorLogDetails.Error_Msg = ex.Message;
        //        objOrderErrorLogDetails.Tr_Date = DateTime.Now;

        //        dbContext.OrderErrorLogDetails.Add(objOrderErrorLogDetails);
        //        var i = dbContext.SaveChanges();

        //        if (i != 0)
        //        {
        //            objResponse.Message = "Exception Logged Successfully";
        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //        }
        //        else
        //        {
        //            objResponse.Message = "Failed";
        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //        }

        //        //objCommonClasses.InsertExceptionDetails(ex, "UserController", "SubmitFeedback");
        //        //return Request.CreateErrorResponse(HttpStatusCode.ExpectationFailed, ex.Message);

        //    }


        //}


        //public string AddOrderProductDetail(OrderDetailsViewModel objOrderDetailsViewModel)
        //{
        //    var i = 0;

        //    try
        //    {
        //        //get mobileNumber from user table
        //        string mobileNumber = objOrderDetailsViewModel.Retailer_Mobile;
        //        var number = (from user in dbContext.UserInfo where user.MobileNumber == mobileNumber select user).FirstOrDefault();
        //        if (number != null)
        //        {
        //            OrderProductDetails objOrderProductDetails = new OrderProductDetails();
        //            var getcsvfile = objOrderDetailsViewModel.csvfile.Table1;

        //            foreach (var j in getcsvfile)
        //            {
        //                objOrderProductDetails.order_id = Convert.ToInt32(objOrderDetailsViewModel.Order_Id);
        //                objOrderProductDetails.product_id = j.product_Id;
        //                objOrderProductDetails.qty = j.OrderQuantity;
        //                objOrderProductDetails.price = j.price;
        //                objOrderProductDetails.tr_date = DateTime.Now;
        //                objOrderProductDetails.SAP_order_ID = objOrderDetailsViewModel.SAP_Order_ID;
        //                dbContext.OrderProductDetails.Add(objOrderProductDetails);
        //                i = dbContext.SaveChanges();


        //            }

        //            //objOrderProductDetails.product_id = "115001003CBE17";
        //            //objOrderProductDetails.qty = "60";
        //            //objOrderProductDetails.price = "410";




        //            if (i != 0)
        //            {
        //                objResponse.Message = objOrderDetailsViewModel.Totalprice;
        //                return objResponse.Message;
        //            }
        //            else
        //            {
        //                objResponse.Message = "Failed";
        //                return objResponse.Message;
        //            }
        //        }
        //        else
        //        {
        //            objResponse.Message = "Mobile number not exists.";

        //            return objResponse.Message;

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Info(Convert.ToString(ex.InnerException));
        //        Log.Info(ex.Message);

        //        OrderErrorLogDetails objOrderErrorLogDetails = new OrderErrorLogDetails();
        //        objOrderErrorLogDetails.Retailer_Id = objOrderDetailsViewModel.Retailer_Id;
        //        objOrderErrorLogDetails.Retailer_Mobile = objOrderDetailsViewModel.Retailer_Mobile;
        //        objOrderErrorLogDetails.PaymentMode = objOrderDetailsViewModel.Payment_Mode;
        //        objOrderErrorLogDetails.Total_Price = objOrderDetailsViewModel.Totalprice;
        //        objOrderErrorLogDetails.Qty = objOrderDetailsViewModel.Qty;
        //        objOrderErrorLogDetails.Csv_File = JsonConvert.SerializeObject(objOrderDetailsViewModel.csvfile.Table1);
        //        objOrderErrorLogDetails.Error_Msg = ex.Message;
        //        objOrderErrorLogDetails.Tr_Date = DateTime.Now;

        //        dbContext.OrderErrorLogDetails.Add(objOrderErrorLogDetails);
        //        i = dbContext.SaveChanges();

        //        if (i != 0)
        //        {
        //            objResponse.Message = "Exception Logged Successfully";
        //            return objResponse.Message;
        //        }
        //        else
        //        {
        //            objResponse.Message = "Failed to Log Exception";
        //            return objResponse.Message;
        //        }

        //        //    objCommonClasses.InsertExceptionDetails(ex, "UserController", "AddOrderProductDetail");
        //        //    return ex.Message;
        //    }

        //}


        ///// <summary>
        ///// To Update Order Details.
        ///// </summary>
        ///// <param name="objOrderDetailsViewModel"></param>
        ///// <returns></returns>
        //[HttpPost]
        ////[Authorize]
        //[Route("api/User/UpdateOrderDetails")]
        //public HttpResponseMessage UpdateOrderDetails(OrderDetailsViewModel objOrderDetailsViewModel)
        //{

        //    try
        //    {
        //        OrderDetails objOrderDetails = new OrderDetails();
        //        int orderId = Convert.ToInt32(objOrderDetailsViewModel.Order_Id);
        //        //get Order from OrderDetails table
        //        var orderDetails = (from order in dbContext.OrderDetails where order.Order_Id == orderId select order).FirstOrDefault();
        //        if (orderDetails != null && orderDetails.Payment_Mode == "Pay Online" && objOrderDetailsViewModel.Rzp_Payment_Status == "Paid")
        //        {

        //            orderDetails.Rzp_Order_Id = objOrderDetailsViewModel.Rzp_Order_Id;
        //            orderDetails.Rzp_Payment_Id = objOrderDetailsViewModel.Rzp_Payment_Id;
        //            orderDetails.Rzp_Signature = objOrderDetailsViewModel.Rzp_Signature;
        //            orderDetails.Rzp_Payment_Status = objOrderDetailsViewModel.Rzp_Payment_Status;


        //            var i = dbContext.SaveChanges();
        //            if (i != 0)
        //            {
        //                TransactionResponse objTransactionResponse = new TransactionResponse();
        //                objTransactionResponse.Order_Id = objOrderDetailsViewModel.Order_Id;
        //                objTransactionResponse.Rzp_Order_Id = objOrderDetailsViewModel.Rzp_Order_Id;
        //                objTransactionResponse.Rzp_Payment_Id = objOrderDetailsViewModel.Rzp_Payment_Id;
        //                objTransactionResponse.Rzp_Signature = objOrderDetailsViewModel.Rzp_Signature;
        //                objTransactionResponse.Rzp_Payment_Status = objOrderDetailsViewModel.Rzp_Payment_Status;
        //                objTransactionResponse.Rzp_payment_message = "Order placed successfully";
        //                objTransactionResponse.Totalprice = objOrderDetailsViewModel.Totalprice;

        //                return Request.CreateResponse(HttpStatusCode.OK, objTransactionResponse);
        //            }
        //            else
        //            {
        //                objResponse.Message = "Transaction Failed.";

        //                return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //            }

        //        }

        //        else if (objOrderDetailsViewModel.Rzp_Payment_Status == "Fail")
        //        {
        //            orderDetails.Rzp_Payment_Status = objOrderDetailsViewModel.Rzp_Payment_Status;
        //            var i = dbContext.SaveChanges();
        //            if (i != 0)
        //            {
        //                TransactionResponse objTransactionResponse = new TransactionResponse();
        //                objTransactionResponse.Order_Id = objOrderDetailsViewModel.Order_Id;
        //                objTransactionResponse.Rzp_Order_Id = objOrderDetailsViewModel.Rzp_Order_Id;
        //                objTransactionResponse.Rzp_Payment_Id = objOrderDetailsViewModel.Rzp_Payment_Id;
        //                objTransactionResponse.Rzp_Signature = objOrderDetailsViewModel.Rzp_Signature;
        //                objTransactionResponse.Rzp_Payment_Status = objOrderDetailsViewModel.Rzp_Payment_Status;
        //                objTransactionResponse.Rzp_payment_message = objOrderDetailsViewModel.Rzp_payment_message;
        //                objTransactionResponse.Totalprice = objOrderDetailsViewModel.Totalprice;

        //                return Request.CreateResponse(HttpStatusCode.OK, objTransactionResponse);
        //            }
        //            else
        //            {
        //                objResponse.Message = "Error occured While Saving Transaction Status.";

        //                return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //            }

        //        }
        //        else
        //        {
        //            objResponse.Message = "No Order Details Found.";

        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Info(Convert.ToString(ex.InnerException));
        //        Log.Info(ex.Message);

        //        OrderErrorLogDetails objOrderErrorLogDetails = new OrderErrorLogDetails();
        //        objOrderErrorLogDetails.Retailer_Id = objOrderDetailsViewModel.Retailer_Id;
        //        objOrderErrorLogDetails.Retailer_Mobile = objOrderDetailsViewModel.Retailer_Mobile;
        //        objOrderErrorLogDetails.PaymentMode = objOrderDetailsViewModel.Payment_Mode;
        //        objOrderErrorLogDetails.Total_Price = objOrderDetailsViewModel.Totalprice;
        //        objOrderErrorLogDetails.Qty = objOrderDetailsViewModel.Qty;
        //        //objOrderErrorLogDetails.Csv_File =;
        //        objOrderErrorLogDetails.Error_Msg = ex.Message;
        //        objOrderErrorLogDetails.Tr_Date = DateTime.Now;

        //        dbContext.OrderErrorLogDetails.Add(objOrderErrorLogDetails);
        //        var i = dbContext.SaveChanges();

        //        if (i != 0)
        //        {
        //            objResponse.Message = "Exception Logged Successfully";
        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //        }
        //        else
        //        {
        //            objResponse.Message = "Failed";
        //            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //        }


        //    }


        //}



        ///// <summary>
        ///// To Get Order Details History.
        ///// </summary>
        ///// <param name="objOrderHistoryViewModel"></param>
        ///// <returns></returns>
        //[HttpPost]
        //[Authorize]
        //[Route("api/User/GetOrderHistory")]
        //public HttpResponseMessage GetOrderHistory(OrderHistoryViewModel objOrderHistoryViewModel)
        //{


        //    try
        //    {
        //        OrderList objOrderList = new OrderList();
        //        List<OrderHistoryViewModel> objListOrderHistory = new List<OrderHistoryViewModel>();
        //        string mobileNumber = objOrderHistoryViewModel.Retailer_Mobile;

        //        //get mobileNumber from user table
        //        var getUser = (from user in dbContext.UserInfo where user.MobileNumber == mobileNumber select user).FirstOrDefault();


        //        var getOrderList = (from orderList in dbContext.OrderDetails
        //                            join product in dbContext.OrderProductDetails on orderList.Order_Id equals product.order_id
        //                            join address in dbContext.UsersAddress on orderList.Shipping_Address_Id equals address.tr_id
        //                            join productmaster in dbContext.Product_Master on product.product_id equals productmaster.ItemCode

        //                            orderby orderList.Order_Id descending
        //                            select new
        //                            {
        //                                orderList.Order_Id,
        //                                orderList.Retailer_Id,
        //                                orderList.Retailer_Mobile,
        //                                orderList.Totalprice,
        //                                orderList.Payment_Mode,
        //                                orderList.Shipping_Address_Id,
        //                                orderList.Order_Status,
        //                                orderList.OrderDate,
        //                                address.reciver_name,
        //                                address.ship_address,
        //                                address.city,
        //                                address.pincode,
        //                                address.ship_mobile,
        //                                product.qty,
        //                                productmaster.SkuName

        //                            }).ToList();



        //        if (getOrderList != null)
        //        {

        //            foreach (var i in getOrderList)
        //            {
        //                OrderHistoryViewModel objOrderHistoryList = new OrderHistoryViewModel()
        //                {
        //                    Order_Id = Convert.ToString(i.Order_Id),
        //                    Retailer_Id = i.Retailer_Id,
        //                    Retailer_Mobile = i.Retailer_Mobile,
        //                    Totalprice = i.Totalprice,
        //                    Payment_Mode = i.Payment_Mode,
        //                    Shipping_Address_Id = Convert.ToString(i.Shipping_Address_Id),
        //                    Order_Status = i.Order_Status,
        //                    OrderDate = Convert.ToString(i.OrderDate),
        //                    reciver_name = i.reciver_name,
        //                    ship_address = i.ship_address,
        //                    city = i.city,
        //                    pincode = i.pincode,
        //                    ship_mobile = i.ship_mobile,
        //                    Qty = i.qty,
        //                    ProductName = i.SkuName



        //                };
        //                objListOrderHistory.Add(objOrderHistoryList);
        //            }


        //            objOrderList.Orders = objListOrderHistory;
        //            return Request.CreateResponse(HttpStatusCode.OK, objOrderList);
        //        }
        //        objResponse.Message = "Order History not found";
        //        return Request.CreateResponse(HttpStatusCode.OK, objResponse);


        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Info(Convert.ToString(ex.InnerException));
        //        Log.Info(ex.Message);
        //        objCommonClasses.InsertExceptionDetails(ex, "UserController", "GetOrderHistory");
        //        return Request.CreateErrorResponse(HttpStatusCode.ExpectationFailed, ex.Message);
        //    }

        //}


        //#endregion


        #region User Wallet functionality

        [HttpPost]
        //[Authorize]
        [Route("api/User/UpdateWalletBalance")]
        public HttpResponseMessage UpdateWalletBalance(UserWalletViewModel objAddress)
        {
            try
            {
                User_Wallet objUserWallet = new User_Wallet();
                string mobileNumber = objAddress.MobileNumber;
                //get mobileNumber from user table
                var number = (from user in dbContext.Shop_Retailer_UserMaster where user.mobile_number == mobileNumber select user).FirstOrDefault();
                if (number != null)
                {

                    var CheckBalanceforUser = (from balance in dbContext.User_Wallet where balance.user_code == mobileNumber select balance).FirstOrDefault();
                    if (CheckBalanceforUser != null)
                    {
                        int Availablebalance = Convert.ToInt32(CheckBalanceforUser.UserBalance);
                        int TobeDeductedAmount = Convert.ToInt32(objAddress.WalletBalance);
                        int totalAmount = Availablebalance - TobeDeductedAmount;

                        objUserWallet.Id = CheckBalanceforUser.Id;
                        var getWalletInfo = (from balance in dbContext.User_Wallet where balance.Id == CheckBalanceforUser.Id select balance).FirstOrDefault();

                        getWalletInfo.UserBalance = totalAmount.ToString();

                        getWalletInfo.ModifiedDate = DateTime.Now;



                        dbContext.Entry(getWalletInfo).State = EntityState.Modified;
                        var i = dbContext.SaveChanges();
                        if (i != 0)
                        {
                            objResponse.Message = "Wallet balance updated successfully";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                        else
                        {
                            objResponse.Message = "Failed to add wallet balance.";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                    }
                    else
                    {
                        objResponse.Message = "Mobile number not exists.";

                        return Request.CreateResponse(HttpStatusCode.OK, objResponse);

                    }

                }
                else
                {
                    objResponse.Message = "Mobile number not exists.";

                    return Request.CreateResponse(HttpStatusCode.OK, objResponse);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// for adding wallet balance 
        /// </summary>
        /// <param name="objAddress"></param>
        /// <returns></returns>
        [HttpPost]
        //[Authorize]
        //[Route("api/User/AddWalletBalance")]
        public HttpResponseMessage AddWalletBalance(UserWalletViewModel objAddress)
        {
            try
            {
                //  UserWalletViewModel objAddress = new UserWalletViewModel();
                User_Wallet objUserWallet = new User_Wallet();
                string mobileNumber = objAddress.MobileNumber;
                //get mobileNumber from user table
                var number = (from user in dbContext.Shop_Retailer_UserMaster where user.user_code == mobileNumber select user).FirstOrDefault();
                if (number != null)
                {

                    var CheckBalanceforUser = (from balance in dbContext.User_Wallet where balance.user_code == mobileNumber select balance).FirstOrDefault();
                    if (CheckBalanceforUser == null)
                    {
                        objUserWallet.Id = objAddress.Id;
                        objUserWallet.UserBalance = objAddress.WalletBalance;
                        objUserWallet.user_code = objAddress.MobileNumber;
                        //objUserWallet.Status = true;
                        objUserWallet.CreatedDate = DateTime.Now;



                        dbContext.User_Wallet.Add(objUserWallet);
                        var i = dbContext.SaveChanges();
                        if (i != 0)
                        {
                            objResponse.Message = "Wallet balance added successfully";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                        else
                        {
                            objResponse.Message = "Failed to add wallet balance.";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                    }
                    else
                    {
                        int Availablebalance = Convert.ToInt32(CheckBalanceforUser.UserBalance);
                        int TobeAddedAmount = Convert.ToInt32(objAddress.WalletBalance);
                        int totalAmount = Availablebalance + TobeAddedAmount;

                        objUserWallet.Id = CheckBalanceforUser.Id;
                        var getWalletInfo = (from balance in dbContext.User_Wallet where balance.Id == CheckBalanceforUser.Id select balance).FirstOrDefault();

                        getWalletInfo.UserBalance = totalAmount.ToString();

                        getWalletInfo.ModifiedDate = DateTime.Now;



                        dbContext.Entry(getWalletInfo).State = EntityState.Modified;
                        var i = dbContext.SaveChanges();
                        if (i != 0)
                        {
                            objResponse.Message = "Wallet balace added successfully";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                        else
                        {
                            objResponse.Message = "Failed to add wallet balance.";
                            return Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        }
                    }
                }
                else
                {
                    objResponse.Message = "Mobile number not exists.";

                    return Request.CreateResponse(HttpStatusCode.OK, objResponse);

                }
            }
            catch (Exception ex)
            {
                //Log.Info(Convert.ToString(ex.InnerException));
                //Log.Info(ex.Message);
                //objCommonClasses.InsertExceptionDetails(ex, "UserController", "AddWalletBalance");
                objResponse.Message = "Mobile number not exists.";
                return Request.CreateErrorResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }

        }



        [HttpPost]
        //[Authorize]
        [Route("api/User/GetWalletInfo")]
        public HttpResponseMessage GetWalletInfo(UserMobileNumber objUserMobileNumber)
        {
            try
            {
                string mobileNumber = objUserMobileNumber.MobileNumber;

                var userwalletDetails = (from user in dbContext.User_Wallet where user.user_code == mobileNumber select user).FirstOrDefault();
                if (userwalletDetails != null)
                {
                    UserWalletViewModel objUserWalletViewModel = new UserWalletViewModel()
                    {
                        Id = userwalletDetails.Id,
                        MobileNumber = userwalletDetails.user_code,
                        // Status = userwalletDetails.Status,
                        WalletBalance = userwalletDetails.UserBalance,

                    };
                    return Request.CreateResponse(HttpStatusCode.OK, objUserWalletViewModel);
                }
                objResponse.Message = "User wallet does Not exist";
                return Request.CreateResponse(HttpStatusCode.OK, objResponse);
            }
            catch (Exception ex)
            {
                // Log.Info(Convert.ToString(ex.InnerException));
                // Log.Info(ex.Message);
                //objCommonClasses.InsertExceptionDetails(ex, "UserController", "GetUserWalletInfo");
                return Request.CreateErrorResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }

        }


        #endregion
    }
}
