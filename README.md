# angular-auth-backend
Authentication backend project for angular-aut repo 

JSON REQUEST :

```
{
    "email": "sean@test.com",
    "password": "SeanPass"
}
```


SAMPLE RESPONSE :
```
{
    "data": {
        "userGroup": 0,
        "token": "8a2cfe059e8642b7adc367c6415428a6"
    },
    "status": 0,
    "error": null
}
```

API REQUEST MODEL:

```
public class ApiRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
```

API RESPONSE MODEL: 

```
public class ApiResult<string>
    {
        [JsonPropertyName("data")]
        public string Data { get; set; }
        [JsonPropertyName("status")]
        public ApiStatus Status { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
```

```
    public enum ApiStatus
    {
        Ok = 0,
        Error = 1
    }
```
