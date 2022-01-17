const path = require("path");
const CopyWebpackPlugin = require('copy-webpack-plugin');
const HtmlWebpackPlugin = require("html-webpack-plugin");

module.exports = {
    entry: "./src/main.js",
    output: {
        path: path.join(__dirname, "../wwwroot/"),
        filename: "bundle.js"
    },
    devtool: "source-map",
    module: {
        rules: [
            {
                test: /\.jsx?$/,
                exclude: /node_modules/,
                loader: "babel-loader",
                options:{
                   presets:["@babel/preset-env", "@babel/preset-react"],
                   plugins:["@babel/plugin-proposal-class-properties"]
               }
            },
            {
                test: /\.css$/,
                use: ["style-loader", "css-loader"]
            }
        ]
    },
    plugins: [
        new HtmlWebpackPlugin({
            template: "./src/index.html"
        })
    ],
    devServer: {
        contentBase: 'src/',
        historyApiFallback: true,
        disableHostCheck: true,
        proxy: {
            '/api/*': {target: 'http://localhost:58725', secure: false},
            '/reports': {target: 'http://localhost:58725', secure: false}
        }
    }
};