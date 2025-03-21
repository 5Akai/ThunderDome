#!/bin/bash

# Lista reducida
LISTA=~/wordlists/seclists/Discovery/Web-Content/directory-list-2.3-small.txt

# Puertos principales y sospechosos
puertos_principales="80 443 8190"
puertos_sospechosos="784 8381 8196 8443 8899"

# Escaneo principal
resultado=$(gobuster dir -u http://192.168.31.1 \
    -w $LISTA \
    -x html,php,txt,json,cgi \
    -t 15 \
    --timeout 5s \
    -r)

# Si hay resultados interesantes, explorar puertos sospechosos
if [[ ! -z "$resultado" ]]; then
    echo "Resultados encontrados. Explorando puertos sospechosos..."
    
    for puerto in $puertos_sospechosos; do
        curl -v -m 5 http://192.168.31.1:$puerto
    done
fi
