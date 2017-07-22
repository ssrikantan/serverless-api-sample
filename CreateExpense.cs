#r "Newtonsoft.Json"
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
public static async Task<HttpResponseMessage> Run(HttpRequestMessage req,
                            IAsyncCollector<dynamic> collector, TraceWriter log)
{
    log.Info("Received Expense creation request... ");
    dynamic data = await req.Content.ReadAsAsync<object>();
    // Create the Expense object dynamically by parsing the Request Body 
    dynamic expenseDocument = new
    {
        id = System.Guid.NewGuid(),
        empid = data.empid,
        email = data.email,
        expensedate = data.expensedate,
        description = "expenses to meet- " + data.item,
        amount = data.amount,
        currency = data.currency,
        country = data.country,
        item = data.item
    };
    log.Info($"C# expense data inserted: " + expenseDocument);
    //since this script requires multiple output parameters, an IAsyncCollector<T> is used
    // this collector stores the expense document, and uses the Output binding to
    // call Cosmos DB to insert it asynchronously, even as the HttpResponse is returned
    await collector.AddAsync(expenseDocument);
    return req.CreateResponse(HttpStatusCode.OK, "expense data inserted");
}
