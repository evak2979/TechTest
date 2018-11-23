## Bookatable's coding test

Welcome to Bookatable's coding test.

The solution mainly comprises a rudimentary event-queue mechanism (OffersQueue), an observer (OffersSubscriber) and a repository (Offersrepository) implementing a simple No-Sql DB solution.

We have already set up OffersSubscriber to listen for messages from OffersQueue. What we would like of you is to implement the actual OffersSubscriber class. 
While doing so, you should ensure that:

1. If there are no records in the DB with the incoming message's Id, use the Repository class to insert a new record in the DB comprising all the fields of the incoming message.
2. If there exists a record in the DB with the incoming message's Id, use the Repository class to update the existing record.

You should not need to modify any of the interfaces, or any other classes save for OffersSubscriber. However, you are welcome to modify methods instantiating OffersSubscriber if you find yourself
needing to add a constructor to the class. You are welcome to create new classes and interfaces as you see fit. 

### How to submit your solution to us:

1. Download this repo locally, and then publish it as a new repo to your github/bitbucket account.
2. Create a branch off master, and start working on that branch. 
2. Try and work on the newly created repo as you normally would in a professional environment - name your commits as you normally would, push as often as you normally would. 
This will allow us to better understand your ways of working as a developer.
3. Once done, create a PR towards master and send us the URL of your completed solution. We will do our best to get back to you ASAP.

Thank you and good luck.