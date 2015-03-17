#!/usr/bin/python
import socket
import struct
import fcntl
import subprocess
import sys
import time
#Looking for data through the following IP and port
MCAST_GRP = '224.1.1.1'
MCAST_PORT = 5007

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM, socket.IPPROTO_UDP)
sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
sock.bind(('', MCAST_PORT))
mreq = struct.pack("4sl", socket.inet_aton(MCAST_GRP), socket.INADDR_ANY)

sock.setsockopt(socket.IPPROTO_IP, socket.IP_ADD_MEMBERSHIP, mreq)
#Get the name of ip address that just give a file
def get_ip_address(ifname):
s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
return socket.inet_ntoa(fcntl.ioctl(
s.fileno(),
0x8915, # SIOCGIFADDR
struct.pack('256s', ifname[:15])
)[20:24])

id = get_ip_address('eth0')
#Differentiate each files by the last ip number
ip1, ip2, ip3, ip4 = id.split('.')

print 'ID: ' + ip4 

#Create an options file, this file should contain the parameters for the raspistill image cmd
optionfile = open('/server/options.cfg','r')
options = optionfile.readline()
optionfile.close()
print "optons: " + options
#Shoot picture at different times to reduce power usage. Also deposits all the pictures into a new folder.
while True:
data = sock.recv(10240)
data = data.strip()
if data == "reboot":
print "Rebooting..."
cmd = 'sudo reboot'
pid = subprocess.call(cmd, shell=True) 
else:
print "shooting " + data
time.sleep(random.choice([0,1,2,3,4,5,6,7,8,9,10]))
cmd = 'raspistill -o /tmp/photo.jpg ' + options 
pid = subprocess.call(cmd, shell=True)
print "Creating directory"
cmd = 'mkdir /server/3dscan/' + data 
pid = subprocess.call(cmd, shell=True)
print "Copy image"
cmd = 'cp /tmp/photo.jpg /server/3dscan/' + data + "/" + data + "_" + ip4 + '.jpg'
pid = subprocess.call(cmd, shell=True)
print "Photo uploaded"
