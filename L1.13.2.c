#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main (int argc, char *argv[]){
	int sock_conn, sock_listen,ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	
	if ((sock_listen = socket(AF_INET, SOCK_STREAM,0)) < 0)
		printf("Error creando el socket");
	
	memset(&serv_adr,0,sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port = htons(9100);
	if(bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind");
	
	if (listen(sock_listen,3) <0)
		printf("error al listen");
	
	int i;
	for (;;) {
		printf("Escuchando\n");
		
		sock_conn = accept(sock_listen,NULL,NULL);
		printf("He recibido conexion\n");
		int terminar =0;
		while (terminar == 0)
		{
			ret= read(sock_conn,peticion,sizeof(peticion));
			
			peticion[ret]= '\0';
			
			printf("Peticion: %s\n", peticion);
			char *p = strtok(peticion, "/");
			int codigo = atoi(p);
			
			if (codigo != 0){
				p = strtok(NULL,"/");
				float grados = atof(p);
				printf("Codigo: %d,Grados %d\n", codigo,grados);
			}
			if (codigo == 0)
				terminar = 1;
				
			else if (codigo == 1){
				p = strtok(NULL,"/");
				float grados = atof(p);
				float grados1;
				grados1= (grados*9/5) +32;
				strcpy(respuesta,grados1);
			}
			else if (codigo == 2){
				p = strtok(NULL,"/");
				float grados = atof(p);
				float grados2;
				grados2 = (grados-32)*5/9;
				strcpy(respuesta,grados2);
			}
				if (codigo != 0){
					printf("Respuesta: %s\n", respuesta);
					write(sock_conn,respuesta,strlen(respuesta));
				}
		}
			
			close(sock_conn);
		}
		
		
	}
