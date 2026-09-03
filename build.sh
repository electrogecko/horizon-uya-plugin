#!/bin/bash
set -e

rm -rf out
rm -rf server
rm -rf out/medius
rm -rf out/dme
mkdir -p out/medius
mkdir -p out/dme
mkdir -p server

cp ../horizon-server server -r

docker build . -t uya_plugin

docker run --rm -v "${PWD}/out/":/mnt/out uya_plugin

chmod a+rw out -R || true

