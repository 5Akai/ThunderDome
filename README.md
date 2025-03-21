# ¿Que es esto?

#### Son scripts para automatizar auditorías muy muy básicas, no hay mucho pero es trabajo honesto, Lo creé hace bastante pero no estaba público, hasta ahora...
###  IMPORTANTE: Para uso educativo y experimentación dentro de un entorno controlado.

## IP
Escribes una ip y muestra información sobre ella en el terminal

## XSS
Realiza un ataque de fuerza bruta de XSS (quien lo diría) tras escribir los parámetros, incluye lista :D

## Router_scan.sh
Es un script de bash que creé para automatizar un scan a mi router Xiaomi y sus puertos extraños redirigiendo a sitios chinos.
###### (Obviamente se podría usar en cualquier ip, pero no era su proposito inicial)
1. Analiza por fuerza bruta directorios posibles en el objetivo
2. Si encuentra un directorio sospechoso analiza los puertos
3. Captura el tráfico con pcap.
4. Ya haces lo que veas con ese tráfico
##### Puede invertirse el proceso, analizando primero los puertos y luego scaneando a fuerza bruta en todos los puertos sospechosos, tarda muchísimo, no lo recomiendo
##### Necesario instalar gobuster, nmap, wordlist y pcap. El script simplemente los ejecuta no los reemplaza
#### ASCII Art credits: [Twitchquotes](https://www.twitchquotes.com/copypastas/2732)

![ReactJS Resume Website Template](yo.jpg?raw=true 'ReactJS Resume Website Template')
