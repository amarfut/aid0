﻿//function SimilarPostsViewModel() {
//    let self = this;
//    self.similarPosts = ko.observableArray([]);

//    self.getSimilarPosts = function () {
//        $.get('/home/loadsimilarposts?type=1', function (posts) {
//            for (let post of posts) {
//                let p = {
//                    title: post.title,
//                    url: '/home/post?url=' + post.url,
//                    image: 'https://storage.cloud.google.com/youit/' + post.url + '/thumbnail.png'
//                };
//                self.similarPosts.push(p);
//            }
//        });
//    };

//    self.getSimilarPosts();
//}


function StaticPostViewModel() {
    let self = this;
    self.setLike = function (postId) {
        console.log("asdadas");
        self.setReaction(postId, true);
    };

    self.setDislike = function (postId) {
        self.setReaction(postId, false);
    };

    self.setReaction = function (postId, liked) {
        $.ajax({
            url: '/home/setpostreaction',
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify({ PostId: postId, Liked: liked }),
            success: (data) => {
                console.log(data);
                $('#post-likes span').text(data.likes);
                $('#post-dislikes span').text(data.dislikes);

                $('#post-likes').removeClass();
                $('#post-dislikes').removeClass();

                if (data.reaction === 1) {
                    $('#post-likes').addClass('noReaction');
                    $('#post-dislikes').addClass('noReaction');
                }
                else if (data.reaction === 2) {
                    $('#post-likes').addClass("liked");
                    $('#post-dislikes').addClass('noReaction');
                }
                else if (data.reaction === 3) {
                    $('#post-likes').addClass("noReaction");
                    $('#post-dislikes').addClass('disliked');
                }
            },
            error: (error) => {
                if (error.status === 403) {
                    $('#authorizeModal').modal('show');
                }
            }
        });
    };
}

let statisticsPostElem = document.getElementById("post-statistic");
console.log(statisticsPostElem);
ko.applyBindings(new StaticPostViewModel(), statisticsPostElem);


function MorePostsViewModel() {
    let self = this;
    self.morePosts = ko.observableArray([]);
    self.getMorePosts = function () {
        $.get('/home/loadsimilarposts?type=0', function (posts) {
            for (let post of posts) {
                let p = {
                    title: post.title,
                    url: '/home/post?url=' + post.url,
                    image: 'https://storage.cloud.google.com/youit/' + post.url + '/thumbnail.png'
                };
                self.morePosts.push(p);
            }
        });
    };

    self.getMorePosts();
}

//let similarPostsElem = document.getElementById("similar-posts");
let morePostsElem = document.getElementById("more-posts");

//console.log(similarPostsElem);
console.log(morePostsElem);

//ko.applyBindings(new SimilarPostsViewModel(), similarPostsElem);
ko.applyBindings(new MorePostsViewModel(), morePostsElem);