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
	serv_adr.sin_port = htons(9050);
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
			char nombre[20];
			
			if (codigo != 0){
				p = strtok(NULL,"/");
				
				strcpy(nombre,p);
			
				printf("Codigo: %d,Nombre%s\n", codigo,nombre);
			}
			if (codigo == 0)
				terminar = 1;
				
			else if (codigo == 1){
				strcpy(nombre,p);
				int i=0;
				int f= strlen(nombre)-1;
				while (i < f){
					if (tolower(nombre[i]) == tolower(nombre[f]))
					{
						sprintf(respuesta, "SI");
					}
					else{
						sprintf(respuesta,"NO");
					}
					i++;
					f--;
				}
			}
			else if (codigo == 2){
				strcpy(nombre,p);
				int i=0;
				while( i < strlen(nombre)){
					nombre[i] = toupper(nombre[i]);
					i++;
				}
				sprintf(respuesta, nombre);
			}
				if (codigo != 0){
					printf("Respuesta: %s\n", respuesta);
					write(sock_conn,respuesta,strlen(respuesta));
				}
		}
			
			close(sock_conn);
		}
		
		
	}
	

	

