## Bookatable's coding test

Welcome to Bookatable's coding test.

The solution comprises a rudimentary message publishing mechanism (OffersPublisher), a rudimentary event-queue mechanism (OffersQueue), 
an observer (OffersSubscriber) and a repository (Offersrepository) implementing a simple No-Sql DB solution.

We have already set up OffersPublisher to publish messages to OffersQueue and OffersSubscriber to listen for messages from OffersQueue. 
What we would like of you is to implement the actual OffersSubscriber class, and ensure the following:

1. Using the Repository class, check for existing records with the incoming message's Id. If none exist, use the Repository class to insert a new record in the DB comprising all the fields of the incoming message.
2. Using the Repository class, check for existing records with the incoming message's Id. If one exists, use the Repository class to update the existing record.

You should not need to modify any of the interfaces, or any of the classes other than OffersSubscriber. However, you are welcome to modify parts of the code that create new instances of the 
OffersSubscriber class should you find yourself needing to add a constructor to OffersSubscriber.

### How to submit your solution to us:

1. Download this repo locally, and then publish it as a new repo to your github/bitbucket account.
2. Create a branch off master, and start working on that branch. 
2. Try and work on the newly created repo as you normally would in a professional environment - name your commits as you normally would, push as often as you normally would. 
This will allow us to better understand your ways of working as a developer.
3. Once done, create a PR towards master and send us the URL of your completed solution. We will do our best to get back to you ASAP.

Thank you and good luck.