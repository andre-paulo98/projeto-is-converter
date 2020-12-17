var http = require('http');
const port = 8080;

http.createServer(function (request, response) {
    const { headers, method, url } = request;

    if(method == "GET") {
		response.statusCode = 200;
		response.setHeader('Content-Type', 'application/json');
    	response.write(JSON.stringify([{id: 1, val: "message 1"}, {id: 2, val: "message 2"}],"",4));
		response.end();
    } else {
		let body = []
		request.on('error', (err) => {
			console.error(err);
		}).on('data', (chunk) => {
			body.push(chunk);
		}).on('end', () => {
			body = Buffer.concat(body).toString();
			response.on('error', (err) => {
				console.error(err);
			});

			response.statusCode = 200;
			response.setHeader('Content-Type', 'application/json');
			const responseBody = { headers, method, url, body };

			console.log(body)

			response.write(JSON.stringify(responseBody,"",4));
			response.end();
		});
    }
}).listen(port);

console.log(`Listening on ${port}`);