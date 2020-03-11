# API Documentation
Doc for API endpoints, HTTP verb first then URL.

For the 2 POST mesthod, you can change the route with "user", "accountant" or "masteraccountant". 
Those methods are available for each role

#FinancialManager
## POST - /api/financial/addeffectivedata
Expects a JSON body such as:
months : 0 = january - 11 = december
```json
{
  "month": 0,  
  "year": 2020,
  "eat": 1034.4,
  "grow": 2300.2,
  "learn": 234.2,
  "cashflow": 3000.3
}
```

If succeeded, returns a JSON response with the identical object + an "id" field, as in:
```json
{
  "id": 0,
  "month": 0,
  "year": 2020,
  "eat": 1034.4,
  "grow": 2300.2,
  "learn": 234.2,
  "cashFlow": 3000.3
}
```

## GET - /api/financial/geteffectives
Returns a JSON array with all the prediction objects.

Example response:
```json
[
  {
    "id": 1,
    "month": 0,
    "year": 2019,
    "eat": 36450,
    "grow": 5841,
    "learn": 3454,
    "cashFlow": 6683
  },
  {
    "id": 2,
    "month": 1,
    "year": 2019,
    "eat": 28846,
    "grow": 3865,
    "learn": 2706,
    "cashFlow": 20841
  },
  {
    "id": 3,
    "month": 2,
    "year": 2019,
    "eat": 37297,
    "grow": 6201,
    "learn": 987,
    "cashFlow": 8603
  },
  {
    "id": 4,
    "month": 3,
    "year": 2019,
    "eat": 40650,
    "grow": 2067,
    "learn": 1462,
    "cashFlow": 9760
  },

```
## GET - /api/financial/getpredictions
Returns a JSON array with all the prediction objects.

Example response:
```json
[
  {
    "id": 1,
    "month": 0,
    "year": 2019,
    "eat": 36450,
    "grow": 5841,
    "learn": 3454,
    "cashFlow": 6683
  },
  {
    "id": 2,
    "month": 1,
    "year": 2019,
    "eat": 28846,
    "grow": 3865,
    "learn": 2706,
    "cashFlow": 20841
  },
  {
    "id": 3,
    "month": 2,
    "year": 2019,
    "eat": 37297,
    "grow": 6201,
    "learn": 987,
    "cashFlow": 8603
  },
  {
    "id": 4,
    "month": 3,
    "year": 2019,
    "eat": 40650,
    "grow": 2067,
    "learn": 1462,
    "cashFlow": 9760
  },
```
## POST - /api/financial/addpredictiondata
Expects a JSON body such as:
```
cjson
{
  "month": 0,  (between 0 and 11)
  "year": 2020,
  "eat": 1034.4,
  "grow": 2300.2,
  "learn": 234.2,
  "cashflow": 3000.3
}
```

If succeeded, returns a JSON response with the identical object + an "id" field, as in:
```json
{
  "id": 0,
  "month": 0,
  "year": 2020,
  "eat": 1034.4,
  "grow": 2300.2,
  "learn": 234.2,
  "cashFlow": 3000.3
}
```

#IssuesManager
## POST - /api/issues/add
Expects a JSON body such as:
months : 0 = january - 11 = december
```json
  {
    "creator": {
      "id": 1,
      "name": "Remi"
    },
    "resolver": {
      "id": 2,
      "name": "Julien"
    },
    "priority": 0,
    "name": "Réparer Frigo",
    "deadLine": "2020-03-03T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 1,
      "name": "Bruxelles"
    },
    "sector": {
      "id": 2,
      "name": "Entretien et Travaux"
    },
    "description": "Réparer le frigo 1"
  }
```
## GET - /api/issues/get
Expects a JSON body such as:
months : 0 = january - 11 = december
```json
    {
        "CreatorId": 1,
        "DeadLine": "2020/03/03",
        "Description": "Réparer le frigo 1",
        "Id": 1,
        "IsCompleted": "false",
        "IsSoftDeleted": "false",
        "LocationId": 1,
        "Name": "Réparer Frigo",
        "Priority": 0,
        "ResolverId": 2,
        "SectorId": 1
    },
    {
        "CreatorId": 2,
        "DeadLine": "2020/04/04",
        "Description": "Réparer le frigo 1",
        "Id": 2,
        "IsCompleted": "false",
        "IsSoftDeleted": "false",
        "LocationId": 1,
        "Name": "Réparer Frigo",
        "Priority": 1,
        "ResolverId": 3,
        "SectorId": 1
    },
    {
        "CreatorId": 2,
        "DeadLine": "2020/04/05",
        "Description": "Salle de réunion",
        "Id": 3,
        "IsCompleted": "false",
        "IsSoftDeleted": "false",
        "LocationId": 2,
        "Name": "Réparer les fenêtres",
        "Priority": 2,
        "ResolverId": 4,
        "SectorId": 2
    },
    {
        "CreatorId": 3,
        "DeadLine": "2020/05/05",
        "Description": "Ca va être super !",
        "Id": 4,
        "IsCompleted": "false",
        "IsSoftDeleted": "false",
        "LocationId": 3,
        "Name": "OrganisationFungiParty",
        "Priority": 2,
        "ResolverId": 1,
        "SectorId": 3
    },
    {
        "CreatorId": 4,
        "DeadLine": "2020/03/03",
        "Description": "Réparer le frigo 1",
        "Id": 5,
        "IsCompleted": "true",
        "IsSoftDeleted": "false",
        "LocationId": 1,
        "Name": "Réparer Frigo",
        "Priority": 0,
        "ResolverId": 2,
        "SectorId": 1
    },
    {
        "CreatorId": 1,
        "DeadLine": "",
        "Description": "C'est au premier étage",
        "Id": 6,
        "IsCompleted": "true",
        "IsSoftDeleted": "false",
        "LocationId": 4,
        "Name": "Problème moyen",
        "Priority": 1,
        "ResolverId": 4,
        "SectorId": 4
    }
```
# CustomerManager
## api/CustomersManager/ComGetAll
```json
    {
        "idCustomer": 1,
        "name": "Archen",
        "delivery_Street": "rue de l'Aqueduc",
        "delivery_StreetNumber": 95,
        "delivery_ZipCode": 1050,
        "delivery_Location": "Ixelles",
        "delivery_Information": "Chez Tan",
        "contact_FirstName": "Xavier",
        "contact_LastName": "Gigtelink",
        "contact_Role": "Responsable",
        "contact_Tel": 488872707,
        "contact_Mail": "larchenterre@larchenterre.be",
        "price_WhiteOyster": 17,
        "price_PoplarPholiote": 19,
        "price_OysterMushrooms": 19
    },
    {
        "idCustomer": 2,
        "name": null,
        "delivery_Street": null,
        "delivery_StreetNumber": 0,
        "delivery_ZipCode": 0,
        "delivery_Location": null,
        "delivery_Information": null,
        "contact_FirstName": null,
        "contact_LastName": null,
        "contact_Role": null,
        "contact_Tel": 0,
        "contact_Mail": null,
        "price_WhiteOyster": 0,
        "price_PoplarPholiote": 0,
        "price_OysterMushrooms": 0
    }
```
   
   ## api/CustomersManager/UserGetAll
```json
    {
        "idCustomer": 1,
        "name": "Archen",
        "delivery_Street": "rue de l'Aqueduc",
        "delivery_StreetNumber": 95,
        "delivery_ZipCode": 1050,
        "delivery_Location": "Ixelles",
        "delivery_Information": "Chez Tan",
        "contact_FirstName": "Xavier",
        "contact_LastName": "Gigtelink",
        "contact_Role": "Responsable",
        "contact_Tel": 488872707,
        "contact_Mail": "larchenterre@larchenterre.be",
        "price_WhiteOyster": 17,
        "price_PoplarPholiote": 19,
        "price_OysterMushrooms": 19
    },
    {
        "idCustomer": 2,
        "name": null,
        "delivery_Street": null,
        "delivery_StreetNumber": 0,
        "delivery_ZipCode": 0,
        "delivery_Location": null,
        "delivery_Information": null,
        "contact_FirstName": null,
        "contact_LastName": null,
        "contact_Role": null,
        "contact_Tel": 0,
        "contact_Mail": null,
        "price_WhiteOyster": 0,
        "price_PoplarPholiote": 0,
        "price_OysterMushrooms": 0
    }
```

    
    
