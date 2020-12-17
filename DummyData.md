# Dummy Data

Para obter dados pode ser utilizado:
* **ApiRestInput**
	* Dados do Firebase (TAES): [https://us-central1-taes-shush-b.cloudfunctions.net/getAllData](https://us-central1-taes-shush-b.cloudfunctions.net/getAllData)
	* Dados Dummy locais: GET [127.0.0.1:8080](127.0.0.1:8080)
		* Necessário correr o ficheiro `index.js` da pasta `fake-http-server-nodejs`
* **BrokerInput**
	* Utilizar o projeto `dummy-MQTTPublisher` disponível na solução do projeto.

Para enviar dados pode ser utilizado:
* **ApiRestOutput**
	* Dados Dummy locais: GET [127.0.0.1:8080](127.0.0.1:8080)
		* Necessário correr o ficheiro `index.js` da pasta `fake-http-server-nodejs`