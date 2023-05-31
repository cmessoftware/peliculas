const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/api/weatherforecast",
    "/api/generos"
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7214',
        secure: false
    });

    app.use(appProxy);
};
