# API Documentation
Doc for API endpoints, HTTP verb first then URL.

For the 2 POST mesthod, you can change the route with "user", "accountant" or "masteraccountant". 
Those methods are available for each role

# FinancialManager
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

# IssuesManager
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
    "id": 1,
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
    "deadLine": "2020-04-03T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 1,
      "name": "Bruxelles"
    },
    "sector": {
      "id": 1,
      "name": "Production"
    },
    "description": "Réparer le frigo 1"
  },
  {
    "id": 2,
    "creator": {
      "id": 2,
      "name": "Julien"
    },
    "resolver": {
      "id": 3,
      "name": "Nathan"
    },
    "priority": 1,
    "name": "Réparer Frigo",
    "deadLine": "2020-07-03T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 1,
      "name": "Bruxelles"
    },
    "sector": {
      "id": 1,
      "name": "Production"
    },
    "description": "Réparer le frigo 1"
  },
  {
    "id": 3,
    "creator": {
      "id": 2,
      "name": "Julien"
    },
    "resolver": {
      "id": 4,
      "name": "Carole"
    },
    "priority": 2,
    "name": "Réparer les fenêtres",
    "deadLine": "2020-03-04T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 2,
      "name": "Charleroi"
    },
    "sector": {
      "id": 2,
      "name": "Entretien et Travaux"
    },
    "description": "Salle de réunion"
  },
  {
    "id": 4,
    "creator": {
      "id": 3,
      "name": "Nathan"
    },
    "resolver": {
      "id": 1,
      "name": "Remi"
    },
    "priority": 2,
    "name": "OrganisationFungiParty",
    "deadLine": "2020-12-03T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 3,
      "name": "Gand"
    },
    "sector": {
      "id": 3,
      "name": "GRH"
    },
    "description": "Ca va être super !"
  },
  {
    "id": 5,
    "creator": {
      "id": 4,
      "name": "Carole"
    },
    "resolver": {
      "id": 2,
      "name": "Julien"
    },
    "priority": 0,
    "name": "Réparer Frigo",
    "deadLine": "2020-03-11T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 1,
      "name": "Bruxelles"
    },
    "sector": {
      "id": 1,
      "name": "Production"
    },
    "description": "Réparer le frigo 1"
  },
  {
    "id": 6,
    "creator": {
      "id": 1,
      "name": "Remi"
    },
    "resolver": {
      "id": 4,
      "name": "Carole"
    },
    "priority": 1,
    "name": "Problème moyen",
    "deadLine": "2020-03-03T00:00:00",
    "isCompleted": false,
    "isSoftDeleted": false,
    "location": {
      "id": 4,
      "name": "Liège"
    },
    "sector": {
      "id": 4,
      "name": "Gestion"
    },
    "description": "C'est au premier étage"
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

    
    
