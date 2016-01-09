(function() {
    "use strict";

    var http = require('http'),
        fs = require('fs'),
        formidable = require('formidable'),
        path = require('path'),
        url = require('url'),
        port = 8001;

    http.createServer(function(req, res){
        if(req.url === "/"){
            fs.readdir('files', function(error, files) {
                var allFiles = '<h4>All uploaded files</h4><div>';
                allFiles += '<ul>';
                for(var i = 0, len = files.length; i < len; i+=1){
                    allFiles += '<li>' + files[i] + '</li>';
                }
                allFiles += '</ul';

                fs.readFile('views/home.html', function(error, data){
                    res.writeHead(200);
                    res.write(data + allFiles);
                    res.end();
                });
            });
        }

        if(req.url === '/upload'){
            if(req.method.toLowerCase() === 'post') {
                var form = new formidable.IncomingForm();
                form.uploadDir = 'files';
                form.keepExtensions = true;

                form.parse(req, function(err, fields, files) {
                    res.writeHead(200, {'content-type': 'text/html'});
                    res.end('<a href="/">Go back</a>');
                });
            } else {
                fs.readFile('views/upload.html', function(error, data) {
                    res.writeHead(200, {'content-type': 'text/html'});
                    res.write(data);
                    res.end();
                });
            }
        }
    }).listen(port);
}());

