print('===============Create devices===============');
db.devices.insert({ Name: 'HomeDoor', Type: 'smartlock', Locked: false });

print('===============Create tokens===============');
let firstDeviceId = db.devices.findOne({Name: "HomeDoor"})._id.str;
db.tokens.insert({ DeviceId: firstDeviceId, Token: 'tokenfajsjka6a47bd7e6b3d6', Email: 'edraculet@gmail.com' });