# Docker ASP.NET WebAPI Example
This repo is an example of how to run an ASP.NET WebAPI solution in Docker.

## Documentation
Documentation for this repository can be found here: http://bloggedbychris.com/

## Curl Test Commands
The following is a list of curl commands that can be used to test the API once it is running.

*Make sure to fill out the values listed in greater than and less than signs.  Endpoint will depend upon your running environment.  In my dev machine, the endpoint generated for my VirtualBox host is 192.168.99.100.*

**Create New Order:**

Run the following command to use curl to create a new order.
```bash
curl --data '{"FirstName": "Chris", "LastName": "Myers", "Address": {"Street1": "123 Abc St", "City": "Phoenix", "State": "AZ", "Zip": "123456"}}' http://<endpoint>:8080/api/order
```
**Find Order:**

Run the following command to use curl to find an existing order by it's GUID.  
```bash
curl http://<endpoint>:8080/api/order/<order_id>
```
*Note: If the record doesn't exist, you will receive a 404 error message*