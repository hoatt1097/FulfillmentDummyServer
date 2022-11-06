using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FulfillmentDummyServer.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("orders/getOrders")]
        public IActionResult GetOrders()
        {
            var reader = new StreamReader("FakeData/GetOrders.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("orders/getOrders/{purchaseOrderNumber}")]
        public IActionResult GetOrder()
        {
            var reader = new StreamReader("FakeData/GetOrder.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("orders/acknowledgements")]
        public IActionResult SubmitAcknowledgements(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("shipping/shippingLabels")]
        public IActionResult SubmitShippingLabels(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/shippingLabels")]
        public IActionResult ShippingLabels()
        {
            var reader = new StreamReader("FakeData/ShippingLabels.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/shippingLabels/{purchaseOrderNumber}")]
        public IActionResult ShippingLabel()
        {
            var reader = new StreamReader("FakeData/ShippingLabel.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("shipping/shipmentConfirmations")]
        public IActionResult SubmitShipmentConfirmations(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("shipping/shipmentStatusUpdates")]
        public IActionResult SubmitShipmentStatusUpdates(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/packingSlips")]
        public IActionResult PackingSlips()
        {
            var reader = new StreamReader("FakeData/PackingSlips.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/packingSlips/{purchaseOrderNumber}")]
        public IActionResult PackingSlip()
        {
            var reader = new StreamReader("FakeData/PackingSlip.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/customerInvoices")]
        public IActionResult CustomerInvoices()
        {
            var reader = new StreamReader("FakeData/CustomerInvoices.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("shipping/customerInvoices/{purchaseOrderNumber}")]
        public IActionResult CustomerInvoice()
        {
            var reader = new StreamReader("FakeData/CustomerInvoice.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("inventory/warehouses/{warehouseId}/items")]
        public IActionResult SubmitInventoryUpdate(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("payments/invoices")]
        public IActionResult SubmitInvoices(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

    }
}
