using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoService.Data;
using AutoService.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace AutoService.Controllers
{
    public class ClientsController : Controller
    {
        private readonly AutoServiceContext _context;

        public ClientsController(AutoServiceContext context)
        {
            _context = context;
        }


        //Получить данные клиента по ID
     
        public string Details(int id)
        {
           
            var clients =  _context.Clients.Where(m => m.Id == id);

            return JsonConvert.SerializeObject(clients);
        }

        public  IActionResult Index()
        {
            var listOfClients = _context.Clients.ToList();
            return View(listOfClients);

        }

        // Получить полный список клиентов

        public string GetClientList()
        {
            var listOfClients = _context.Clients;
            return JsonConvert.SerializeObject(listOfClients);
        }

       //Получить список авто клиентов 
       public ActionResult GetAutoList(int id_cln)
        {
            var autoList = _context.Automobile.Where(m => m.Id_client == id_cln);
            return RedirectToAction("Index", "Automobile", new { id = id_cln });
        }

        //Получить детали авто

        public string GetDataAuto(string  gosn_auto)

        {
          
            var auto = _context.Automobile.Where(m => m.Gosn == gosn_auto);  
           
            return JsonConvert.SerializeObject(auto);
        }

        //Редактировать Авто и вернуть его ID
        public string EditAuto(string gosn, [Bind("Trade_mark,Year,Gosn,Odometr,Vin,Fuel")] Automobile automobile)
        {

            Automobile auto_upd = (from x in _context.Automobile where x.Gosn == gosn select x).First();
            auto_upd.Trade_mark = automobile.Trade_mark;
            auto_upd.Year = automobile.Year;
            auto_upd.Gosn = automobile.Gosn;
            auto_upd.Odometr = automobile.Odometr;
            auto_upd.Vin = automobile.Vin;
            auto_upd.Fuel = automobile.Fuel;
            _context.SaveChanges();
            return automobile.Gosn.ToString();
        }


        //Создать нового клиента и вернуть его ID 
        public string  Create(Clients clients)
        {

            _context.Add(clients);
            _context.SaveChanges();
            int id = clients.Id;
            return id.ToString();
           
        }
      
        public string CreateAuto(Automobile automobile)
        {

            _context.Add(automobile);
            _context.SaveChanges();
            string id = automobile.Gosn;
            return id;

        }

        //Редактировать клиента и вернуть его ID
        public string Edit(int id, [Bind("Id,Fio,Pol,Phone,DateBirdth,Email,DateReg")] Clients clients)
        {
            
            Clients cl_upd = (from x in _context.Clients where x.Id == id select x).First();
            cl_upd.Fio = clients.Fio;
            cl_upd.Pol = clients.Pol;
            cl_upd.Phone = clients.Phone;
            cl_upd.DateBirdth = clients.DateBirdth;
            cl_upd.Email = clients.Email;
            cl_upd.DateReg = clients.DateReg;
            _context.SaveChanges();

            return clients.Id.ToString();

        }

   
       //Удалить клиента
        public string Delete(int id)
        {
            var clients = _context.Clients.Find(id);
            _context.Clients.Remove(clients);
             _context.SaveChangesAsync();
            return "Клиент успешно удален";
        }

        private bool ClientsExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
