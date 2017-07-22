using System.Net;
public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log,
                                                        IEnumerable<dynamic> documents)
{
    log.Info("C# HTTP trigger function processed a request.");
    return documents == null
        ? req.CreateResponse(HttpStatusCode.BadRequest, "No data found matching the criteria!")
        : req.CreateResponse(HttpStatusCode.OK, documents);
}