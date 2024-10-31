# Chat_Client-Server

Este proyecto es una aplicación de chat que permite la comunicación en tiempo real entre un servidor y múltiples clientes. Los dispositivos deben estar conectados a la misma red local para poder establecer la conexión.

## Características

- **Conexión en Tiempo Real**: Permite la comunicación instantánea entre el servidor y múltiples clientes.
- **Interfaz Gráfica de Usuario**: Tanto el cliente como el servidor tienen interfaces intuitivas para facilitar el uso.
- **Conexión a través de IP Local**: Los clientes pueden conectarse al servidor usando su dirección IP local, siempre y cuando estén en la misma red.

## Requisitos

- .NET Framework 4.5 o superior
- Visual Studio (o cualquier otro IDE compatible con C#)

## Instalación

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/guille-nat/Chat_Clint-Server.git

2. Abre el proyecto en Visual Studio.
3. Compila y ejecuta la aplicación del servidor primero.
4. El servidor te dara la dirección IP a la cual te debes conectar con el/los Cliente/s.
5. Inicia la aplicación del cliente y proporciona la dirección IP del servidor en el campo correspondiente.
6. Haz clic en "Conectar".

## Uso

- **Servidor**: Asegúrate de que el servidor esté activo y escuchando en la IP y el puerto correctos (`50000`).
- **Clientes**: Varios clientes pueden conectarse al servidor al mismo tiempo. Cada cliente debe ingresar la dirección IP del servidor y hacer clic en "Conectar".

## Ejemplo de Uso

1. Ejecuta el servidor y verifica que esté escuchando en la dirección IP deseada.
2. Inicia uno o varios clientes.
3. Los clientes pueden enviar mensajes que se mostrarán en el área de texto del cliente y serán recibidos por el servidor.
4. El servidor tambien puede enviar mensajes a los clientes.

## Notas

- Asegúrate de que el firewall de Windows o cualquier otro firewall no esté bloqueando el puerto `50000` para permitir conexiones.
- Todos los dispositivos (servidor y clientes) deben estar conectados a la misma red local.
