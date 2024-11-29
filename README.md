controlgastos
AO CLONAR O PROJETO, LEMBRE DE REALZIAR A TROCA DOS DADOS DE ACESSO AO SEU BANCO DE DADOS MYSQL NO ARQUIVO appsettings.json. O app flutter correspondente ao projeto esta em: https://github.com/arturw9/controlgastos_flutter_front

Video apresentação app: https://drive.google.com/file/d/1BFlmcXJ2F0WIayS6w8srkZkthpXvkD1K/view?usp=drive_link
Logo abaixo os requisitos que foram cumpridos.

Descrição da Atividade: Aplicativo de Controle de Gastos Pessoais

Objetivo Desenvolver um aplicativo de controle de gastos com as seguintes funcionalidades:

Funcionalidades

Tela de Login • Implementar autenticação básica utilizando banco de dados (MySQL ou MariaDB). • Permitir a criação de nova conta e realizar login.
Tela Principal • Exibir lista de transações financeiras do usuário, organizadas por data. • Cada transação deve mostrar: o Descrição o Categoria o Valor • Apresentar um resumo financeiro contendo: o Saldo total. o Totais de receitas e despesas.
Adicionar Transação • Criar tela para adicionar uma nova transação, com os seguintes campos: o Data o Valor o Descrição o Categoria (selecionável). • Implementar validações, como: o Proibição de valores negativos para receitas. o Validação obrigatória do campo "Valor".
Filtros e Organização • Permitir filtros para: o Período (data inicial e final). o Categoria. • Adicionar funcionalidade para ordenar transações por: o Data. o Valor.
Gráficos • Exibir gráficos de barras ou pizza para: o Despesas por categoria. o Evolução dos gastos ao longo do tempo.
Tema Escuro/Claro • Implementar sistema de temas (claro e escuro) configurável pelo usuário.
Responsividade • Garantir que o layout funcione corretamente em: o Smartphones. o Tablets.
Requisitos Técnicos e Avaliação

Organização e Limpeza do Código • Manter uma estrutura modular e organizada no projeto. • Seguir boas práticas de organização de pastas e arquivos.
State Management • Utilizar Provider para gerenciar o estado global e local do aplicativo.
Integração de APIs • Implementar o consumo de uma API externa. • Usar async/await com tratamento de erros.
Boas Práticas de UI e UX • Criar componentes customizados e reutilizáveis. • Seguir princípios do Material Design ou Cupertino Widgets, dependendo da plataforma.
Responsividade • Ajustar o layout para diferentes tamanhos de tela e densidades de pixel.
Tema • Implementar suporte ao tema claro/escuro, utilizando configurações nativas do Flutter.
