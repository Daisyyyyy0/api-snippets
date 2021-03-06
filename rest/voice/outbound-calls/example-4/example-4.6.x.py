# Download the Python helper library from twilio.com/docs/python/install
import os
from twilio.rest import Client

# Your Account Sid and Auth Token from twilio.com/user/account
# To set up environmental variables, see http://twil.io/secure
account_sid = os.environ['TWILIO_ACCOUNT_SID']
auth_token = os.environ['TWILIO_AUTH_TOKEN']

client = Client(account_sid, auth_token)

call = client.api.account.calls.create(
    url="http://demo.twilio.com/docs/voice.xml",
    to="+14155551212",
    from_="+18668675310",
    method="GET",
    status_callback="https://www.myapp.com/events",
    status_callback_method="POST",
    # TODO
    # status_events=["initiated", "ringing", "answered", "completed"]
)

print(call.sid)
