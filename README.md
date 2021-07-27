# TFOQ
Projeto TFOQP
Projeto  ainda não concluido por completo.
TFOQ
A aplicação TFOQ (Tá Faltando O Quê?). A aplicação consiste em um simples repositório para gerenciar mantimentos domésticos e 
mostrar o que acabou e o que é necessário repor.

Mínimo Necessário
Uma aplicação real e simples, sem autenticação, que atenda os requisitos descritos abaixo, utilizando um banco de dados para persistência.
Link do projeto no Github ou semelhantes.
README contendo informações básicas do projeto e como executá-lo

Bônus
Os seguintes itens não são obrigatórios, mas agregam mais valor ao seu trabalho.
Uso de ferramentas que facilitem seu trabalho
Cuidados com otimização, padrões, entre outros
Migrations ou scripts para configuração do banco de dados
Testes
Conteinerização da Aplicação
Autenticação e Autorização (JWT)
Pipelines de CI/CD (Preferencialmente: Github Actions)
Deploy em ambientes reais (Heroku, Google, AWS...)
Sugestões sobre o challenge embasadas em alguma argumentação
Uso de API para separar Frontend de Backend

Requisitos
Deve ser possível visualizar todas os tipos mantimentos cadastrados com opção de busca com filtros
Deve ser possível cadastrar um novo tipo mantimento
Deve ser possível alterar um tipo mantimento
Deve ser possível remover tipos de mantimentos
Deve ser possível visualizar todas os mantimentos cadastrados com opção de busca com filtros
Deve ser possível cadastrar um novo mantimento
Deve ser possível alterar um mantimento
Deve ser possível remover mantimentos
Tipo de Mantimento:
ID
Nome (ex: leite)
Obrigatório (Se é necessário repor o produto ao acabar ou não)
Tags (Categorias de produto ex para o ‘leite’: [‘#laticinio’, ‘#bebida’])
Um mantimento deve possuir:
ID
Tipo
Marca
Validade
Capacidade (em Unidade, Gramas ou Litros)
Conteúdo atual (Porcentagem)



