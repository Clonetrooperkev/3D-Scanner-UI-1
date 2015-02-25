import socket
import sys
import time

#print 'photo name:'
#n = sys.stdin.readline()
#n = n.strip('\n')
print ("Photo name is: %s" % str(sys.argv[1]))
#Photo name
n = str(sys.argv[1])

#Timer
a = int(sys,argv[2])

time.sleep(a)

#IP and Port
MCAST_GRP = '224.1.1.1'
MCAST_PORT = 5007

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM, socket.IPPROTO_UDP)
sock.setsockopt(socket.IPPROTO_IP, socket.IP_MULTICAST_TTL, 2)
sock.sendto(n, (MCAST_GRP, MCAST_PORT))
