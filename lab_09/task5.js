const http = require('http');

const server = http.createServer((req, res) => {

    if (req.url === '/api') {
        res.setHeader('Content-Type', 'application/json');

        const studentData = {
            name: "Jozza Batool",
            course: "ADCS",
            rollNo: 2500594,
            university: "AIR"
        };

        res.write(JSON.stringify(studentData));

    } else {
        res.write("Go to /api for student data");
    }

    res.end();
});

server.listen(3000, () => {
    console.log("Server running at http://localhost:3000");
});