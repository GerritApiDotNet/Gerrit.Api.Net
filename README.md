# Gerrit.Api.Net 
[![Build Status](https://ci.appveyor.com/api/projects/status/dsn3ld94378c11w8?svg=true)](https://ci.appveyor.com/project/costin-zaharia/gerrit-api-net)

Installation
------------

NuGet:
```
Install-Package Gerrit.Api
```

Examples
--------

```
var gerritConfiguration = new GerritConfiguration("username", "password", "gerrit url");
var changesEndPoint = new ChangesEndpoint(gerritConfiguration);

foreach (var change in changesEndPoint.GetAll(new ChangeQueryParameters {NumberOfResults = 10}, ChangeOptionalParameters.Empty))
{
    Console.WriteLine(change.Subject);
}
```