using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2016WeHackUs_ChildCare.Controllers.APIController
{
    [RoutePrefix ("api/Users")]
    public class UserProfileApiController : ApiController
    {
        // GET api/<controller>


        //[Route("current"), HttpGet]
        //public HttpResponseMessage GetsUser()
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    ItemResponse<UserInfo> response = new ItemResponse<UserInfo>();
        //    string UserId = UserService.GetCurrentUserId();
        //    response.Item = _userDataService.GetByUserId(UserId);
        //    return Request.CreateResponse(response);
        //}

        //[Route("settings"), HttpGet]
        //public HttpResponseMessage Get()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    ItemsResponse<UserSettings> response = new ItemsResponse<UserSettings>();
        //    response.Items = UserService.GetSettings();
        //    return Request.CreateResponse(response);
        //}

        //[Route("sectiondetails"), HttpGet]
        //public HttpResponseMessage GetsUserSectionDetails()
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    ItemResponse<Section> response = new ItemResponse<Section>();
        //    string UserId = UserService.GetCurrentUserId();
        //    response.Item = _sectionService.GetSectionDetailsByUserId(UserId);
        //    return Request.CreateResponse(response);
        //}

        //[Route("OfficeHours"), HttpGet]
        //public HttpResponseMessage GetByDate()
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    ItemsResponse<OfficeHour> response = new ItemsResponse<OfficeHour>();
        //    response.Items = _officeHours.GetByDate();
        //    return Request.CreateResponse(response);
        //}



    }
}