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
        [Route("vendor/directFulfillment/orders/v1/purchaseOrders")]
        public IActionResult GetOrders()
        {
            var reader = new StreamReader("FakeData/GetOrders.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/orders/v1/purchaseOrders/{purchaseOrderNumber}")]
        public IActionResult GetOrder()
        {
            var reader = new StreamReader("FakeData/GetOrder.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/orders/v1/acknowledgements")]
        public IActionResult SubmitAcknowledgements(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/shipping/v1/shippingLabels")]
        public IActionResult SubmitShippingLabels(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/shippingLabels")]
        public IActionResult ShippingLabels()
        {
            var reader = new StreamReader("FakeData/ShippingLabels.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/shippingLabels/{purchaseOrderNumber}")]
        public IActionResult ShippingLabel()
        {
            var reader = new StreamReader("FakeData/ShippingLabel.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/shipping/v1/shipmentConfirmations")]
        public IActionResult SubmitShipmentConfirmations(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/shipping/v1/shipmentStatusUpdates")]
        public IActionResult SubmitShipmentStatusUpdates(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/packingSlips")]
        public IActionResult PackingSlips()
        {
            var reader = new StreamReader("FakeData/PackingSlips.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/packingSlips/{purchaseOrderNumber}")]
        public IActionResult PackingSlip()
        {
            var reader = new StreamReader("FakeData/PackingSlip.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/customerInvoices")]
        public IActionResult CustomerInvoices()
        {
            var reader = new StreamReader("FakeData/CustomerInvoices.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpGet]
        [Route("vendor/directFulfillment/shipping/v1/customerInvoices/{purchaseOrderNumber}")]
        public IActionResult CustomerInvoice()
        {
            var reader = new StreamReader("FakeData/CustomerInvoice.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items")]
        public IActionResult SubmitInventoryUpdate(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

        [HttpPost]
        [Route("vendor/directFulfillment/payments/v1/invoices")]
        public IActionResult SubmitInvoices(Object body)
        {
            var reader = new StreamReader("FakeData/TransactionId.json");
            string fileContent = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<Object>(fileContent)!;
            return Ok(data);
        }

    }
}
