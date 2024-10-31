Feature: Gerenciamento de Sensores Ambientais

  Scenario: Adicionar um novo sensor
    Given que um sensor ambiental com tipo "Temperatura" e valor 25.0
    When o sensor é adicionado
    Then o sistema deve retornar o status 201

  Scenario: Listar sensores
    Given sensores estão cadastrados
    When a lista de sensores é solicitada
    Then o sistema deve retornar o status 200 e a lista de sensores
