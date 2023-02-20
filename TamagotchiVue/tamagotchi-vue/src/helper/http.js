import axios from 'axios';
const token = localStorage.getItem('token');
const bearer = token===null?null:`Bearer ${token}`;
export const http = axios.create({baseURL: 'http://localhost:8881/api/', headers: {Authorization:bearer}});
