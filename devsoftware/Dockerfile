# Etapa 1: Construção da aplicação Angular
FROM node:18 AS build
WORKDIR /app
EXPOSE 80
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build --prod

# Etapa 2: Servir o conteúdo estático usando o NGINX
FROM nginx:alpine
COPY --from=build /app/dist/devsoftware /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
