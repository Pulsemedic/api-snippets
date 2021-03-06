<?php
// Get the PHP helper library from https://twilio.com/docs/libraries/php
require_once '/path/to/vendor/autoload.php'; // Loads the library
use Twilio\Rest\Client;

// Your Account Sid and Auth Token from twilio.com/user/account
$sid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
$token = "your_auth_token";
$client = new Client($sid, $token);

$conferences = $client->conferences->read(
    array("status" => "in-progress", "dateCreated" => "2009-07-06")
);
// Loop over the list of conferences and echo a property for each one
foreach ($conferences as $conference) {
    echo $conference->status;
}
