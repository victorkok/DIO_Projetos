const { createYield } = require("typescript")

describe('Primeiro Teste', ()=> {
    it('Exemplos Cypress', () => {
        cy.visit('https://example.express.io')
        expect(true).to.equal(true)
    })
})