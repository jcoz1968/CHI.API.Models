using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHI.API.Models.Models
{
    public class Submission
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FacilityName { get; set; }
        public string SubmissionType { get; set; }
        public string MedicareId { get; set; }
        public string DataSubmissionType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NumberOfPatients { get; set; }
        public int NumberOfRecords { get; set; }
        public string Comments { get; set; }
        public string Payload { get; set; }


        //[HttpPost, Route("api/upload")]
        //public async Task<IHttpActionResult> Upload()
        //{
        //    if (!Request.Content.IsMimeMultipartContent())
        //        throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

        //    var provider = new MultipartMemoryStreamProvider();
        //    await Request.Content.ReadAsMultipartAsync(provider);
        //    foreach (var file in provider.Contents)
        //    {
        //        var filename = file.Headers.ContentDisposition.FileName.Trim('\"');
        //        var buffer = await file.ReadAsByteArrayAsync();
        //        Do whatever you want with filename and its binaray data.
        //    }

        //    return Ok();
        //}


    }
}
