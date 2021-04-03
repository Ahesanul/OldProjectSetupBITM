using StockManage.BLL.BLL;
using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using StockManageWeb.Models;
using AutoMapper;

namespace StockManageWeb.Controllers
{
    public class CustomerController : Controller
    {
       StockManageCustomerManager _stockManageManger = new StockManageCustomerManager();
        Customer _customer = new Customer();
        CustomerVM _customervm = new CustomerVM();
        

        public ActionResult Add()
        {
           
            _customervm.customers = _stockManageManger.Show();

            return View(_customervm);
        }


        //public ActionResult Add(HttpPostedFileBase postedFile)
        //{

        //    using (BinaryReader br = new BinaryReader(postedFile.InputStream))
        //    {

        //        _customer.Image = br.ReadBytes(postedFile.ContentLength);
        //    }

        //    _stockManageManger.Add(_customer);

        //    return View();
        //}

        [Route("Add")]
        [HttpPost]
        public ActionResult Add(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = Mapper.Map<Customer>(model);

                HttpPostedFileBase image = Request.Files["ImageData"];

                _stockManageManger.Add(customer, image);
                
            }
            _customervm.customers = _stockManageManger.Show();
            return View(_customervm);
        }
            
    

        [HttpPost]
        public ActionResult Show(CustomerVM model)
        {
            Customer customer = Mapper.Map<Customer>(model);
            if (customer.Name != null)
            {
                _customervm.customers = _stockManageManger.search(customer);
               
            }


            return View(_customervm);
        }

        public ActionResult Show()
        {

            _customervm.customers = _stockManageManger.Show();

            return View(_customervm);
        }

        public ActionResult Edit(int? id)
        {
            CustomerVM model = new CustomerVM();
            model.ID = Convert.ToInt32(id);
            Customer customer = Mapper.Map<Customer>(model);
           
            var GetByID = _stockManageManger.GetByID(customer);
            //_customer.customers = _stockManageManger.Show();
            model.Name = GetByID.Name;
            model.Address = GetByID.Address;
            model.Code = GetByID.Code;
            model.Contact = GetByID.Contact;
            model.Email = GetByID.Email;
            model.Loyalty = GetByID.Loyalty;
            

            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CustomerVM model)
        {

            Customer customer = Mapper.Map<Customer>(model);

            

            _stockManageManger.Edit(customer);

            model.customers = _stockManageManger.Show();
            ViewBag.message = "Updated";
            return View(model);
        }


        public ActionResult Delete(int? id)
        {
            CustomerVM model = new CustomerVM();
            model.ID= Convert.ToInt32(id);
            Customer customer = Mapper.Map<Customer>(model);
           
            if (id != null)
            {
                var aCustomer = _stockManageManger.GetByID(customer);
                _stockManageManger.Delete(aCustomer);
            }




            _customervm.customers= _stockManageManger.Show();
            return View(_customervm);

        }


    }
}