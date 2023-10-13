using HttpClient2;

var apiUriPost = "https://reqres.in/api/users";


var contentGetAsyncMethod = await HttpClientMethod.GetAsyncMethod();
var contentGetFromJsonAsyncMethod = await HttpClientMethod.GetFromJsonAsyncMethod();
var contentPostAsJsonAsyncMethod = await HttpClientMethod.PostAsJsonAsyncMethod();

