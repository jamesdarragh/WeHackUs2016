sabio.factories.Search = function (apiRoot, ajaxFx) {

    var thisService = this;
    thisService.get = _get;
 
    function _get(data, onSuccess, onError) {
        var apiLink = apiRoot;
        var settings = {
            cache: false
                , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
                , data: data
                , dataType: "json"
                , success: onSuccess
                , error: onError
                , type: "GET"
        };

        thisService.ajax(apiLink, settings);
    }

}


sabio.services.search = new sabio.factories.Search('/api/search', $.ajax);