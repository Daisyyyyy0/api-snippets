require 'twilio-ruby'

# put your own credentials here
# To set up environmental variables, see http://twil.io/secure
account_sid = ENV['TWILIO_ACCOUNT_SID']
auth_token = ENV['TWILIO_AUTH_TOKEN']

# set up a client to talk to the Twilio REST API
@client = Twilio::REST::Client.new(account_sid, auth_token)

# Loop over recordings and print out a property for each one
@client.recordings.list(
  call_sid: 'CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
).each do |recording|
  puts recording.duration
end
